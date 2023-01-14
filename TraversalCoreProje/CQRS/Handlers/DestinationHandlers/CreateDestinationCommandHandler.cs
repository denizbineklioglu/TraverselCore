using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using TraversalCoreProje.CQRS.Commands.DestinationCommands;

namespace TraversalCoreProje.CQRS.Handlers.DestinationHandlers
{
    public class CreateDestinationCommandHandler
    {
        private readonly Context _context;
        public CreateDestinationCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(CreateDestinationCommand model)
        {
            _context.Destinations.Add(new Destination
            {
                City = model.City,
                Price = model.Price,
                DayNight = model.DayNight,
                Capacity = model.Capacity,
                Status = true
            });
            _context.SaveChanges();
        }
    }
}
