using System.Collections.Generic;

namespace SignalRApiForSql.Models
{
    public class VisitorChart
    {
        public VisitorChart()
        {
            Counts = new List<int>();
        }

        public string VisitDate { get; set; }

        //Şehrin kaç kişi tarafından ziyaret edildiği bilgisi.
        public List<int> Counts { get; set; }
    }
}
