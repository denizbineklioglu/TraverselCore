using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using SignalRApi.DAL;
using SignalRApi.Hubs;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRApi.Model
{
    public class VisitorService
    {

        private readonly Context _context;
        private readonly IHubContext<VisitorHub> _visitorHub;
        public VisitorService(Context context, IHubContext<VisitorHub> visitorHub)
        {
            _context = context;
            _visitorHub = visitorHub;
        }

        public IQueryable<Visitor> GetList()
        {
            return _context.Visitors.AsQueryable();
        }

        public async Task SaveVisitor(Visitor visitor)
        {
            await _context.Visitors.AddAsync(visitor);
            await _context.SaveChangesAsync();

            //Çağırılacak olan method.
            await _visitorHub.Clients.All.SendAsync("CallVisitList","aaa");
        }

        public List<VisitorChart> GetVisitorChartList()
        {
            List<VisitorChart> visitorCharts = new();
            using (var command = _context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "sorgu";
                command.CommandType = System.Data.CommandType.Text;
                _context.Database.OpenConnection();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read()) 
                    {
                        VisitorChart visitorChart = new();
                        visitorChart.VisitDate = reader.GetDateTime(0).ToShortDateString();
                        Enumerable.Range(1, 5).ToList().ForEach(x =>
                        {
                            visitorChart.Counts.Add(reader.GetInt32(x));
                        });
                        visitorCharts.Add(visitorChart);
                    }
                }
                _context.Database.CloseConnection();
                return visitorCharts;
            }            
        }
    }
}
