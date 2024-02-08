using GraphQL;
using GraphQL.Types;
using NewGraphQL.Interfaces;
using NewGraphQL.Model;
using NewGraphQL.Type;

namespace NewGraphQL.Mutation
{
    public class CategoryMutation : ObjectGraphType
    {
        public CategoryMutation(ICategoryRepository categoryRepository)
        {

            Field<CategoryType>("CreateCategory").Arguments(new QueryArguments(new QueryArgument<CategoryInputType> { Name = "category" })).Resolve(context =>
            {
                return categoryRepository.AddCategory(context.GetArgument<Category>("category"));

            });

            Field<StringGraphType>("DeleteCategory").Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "categoryId" })).Resolve(context =>
            {
                categoryRepository.DeleteCategory(context.GetArgument<int>("categoryId"));
                return "category Deleted  for ID" + context.GetArgument<int>("categoryId");

            });

            Field<CategoryType>("UpdateCategory").Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "categoryId" },
                new QueryArgument<CategoryInputType> { Name = "category" })).Resolve(context =>
            {
                return categoryRepository.UpdateCategory(context.GetArgument<int>("menuId"), context.GetArgument<Category>("category"));

            });
        }
    }
}
