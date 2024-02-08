using GraphQL.Types;

namespace NewGraphQL.Type
{
    public class ReservationInputType : InputObjectGraphType
    {
        public ReservationInputType()
        {
            Field<IntGraphType>("id");
            Field<StringGraphType>("customerName");
            Field<StringGraphType>("email");
            Field<IntGraphType>("partySize");
            Field<StringGraphType>("phoneNumber");
            Field<StringGraphType>("specialRequest");
            Field<DateGraphType>("reservationDate");
        }
    }
}
