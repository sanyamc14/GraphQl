using GraphQL.Types;
using NewGraphQL.Interfaces;
using NewGraphQL.Type;

namespace NewGraphQL.Query
{
    public class CategoryQuery : ObjectGraphType
    {
        public CategoryQuery(ICategoryRepository categoryRepository)
        {
            Field<ListGraphType<CategoryQuery>>("Categories").Resolve(context =>
            {
                return categoryRepository.GetCategories();

            });

        }
    }
}
