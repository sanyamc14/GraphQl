using NewGraphQL.Data;
using NewGraphQL.Interfaces;
using NewGraphQL.Model;

namespace NewGraphQL.Services
{
    public class ReservationRepository : IReservationRepository
    {
        private GraphQLDbContext _dbContext;
        
        public ReservationRepository(GraphQLDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Reservation AddReservation(Reservation reservation)
        {
            _dbContext.Reservations.Add(reservation);
            _dbContext.SaveChanges();
            return reservation;
        }

        public List<Reservation> GetAllReservation()
        {
            return _dbContext.Reservations.ToList();
        }
    }
}
