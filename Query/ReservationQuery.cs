using GraphQL.Types;
using NewGraphQL.Interfaces;
using NewGraphQL.Type;

namespace NewGraphQL.Query
{
    public class ReservationQuery : ObjectGraphType
    {
        public ReservationQuery(IReservationRepository reservationRepository)
        {
            Field<ListGraphType<ReservationType>>("Reservations").Resolve(context =>
            {
                return reservationRepository.GetAllReservation();

            });

        }
    }
}
