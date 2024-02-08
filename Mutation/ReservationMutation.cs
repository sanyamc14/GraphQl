using GraphQL;
using GraphQL.Types;
using NewGraphQL.Interfaces;
using NewGraphQL.Model;
using NewGraphQL.Type;

namespace NewGraphQL.Mutation
{
    public class ReservationMutation : ObjectGraphType
    {
        public ReservationMutation(IReservationRepository reservationRepository)
        {

            Field<ReservationType>("createReservation").Arguments(new QueryArguments(new QueryArgument<ReservationInputType> { Name = "reservation" })).Resolve(context =>
            {
                return reservationRepository.AddReservation(context.GetArgument<Reservation>("reservation"));

            });

           
        }
    }
}
