using GraphQL.Types;

namespace NewGraphQL.Type
{
    public class CategoryInputType : InputObjectGraphType
    {
        public CategoryInputType()
        {
            Field<IntGraphType>("id");
            Field<StringGraphType>("name");
            Field<StringGraphType>("imageUrl");      
        }
    }
}
