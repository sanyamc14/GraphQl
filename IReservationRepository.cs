using NewGraphQL.Model;

namespace NewGraphQL.Interfaces
{
    public interface IReservationRepository
    {
        List<Reservation> GetAllReservation();
        //Menu GetReservationById(int id);
        Reservation AddReservation(Reservation reservation);
        //Menu UpdateReservation(int id, Reservation reservation);
        //void DeleteReservation(int id);
    }
}
