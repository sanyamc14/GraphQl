using GraphQL.Types;
using NewGraphQL.Model;

namespace NewGraphQL.Type
{
    public class ReservationType : ObjectGraphType<Reservation>
    {
        public ReservationType() 
        {
            Field(r => r.Id);
            Field(r => r.PhoneNumber);
            Field(r => r.CustomerName);
            Field(r => r.Email);
            Field(r => r.PartySize);
            Field(r => r.ReservationDate);
            Field(r => r.SpecialRequest);

        }
    }
}
