using GraphQL;
using GraphQL.Types;
using NewGraphQL.Interfaces;
using NewGraphQL.Model;
using NewGraphQL.Type;

namespace NewGraphQL.Mutation
{
    public class MenuMutation : ObjectGraphType
    {
        public MenuMutation(IMenuRepository menuRepository)
        {

            Field<MenuType>("CreateMenu").Arguments(new QueryArguments(new QueryArgument<MenuInputType> { Name = "menu" })).Resolve(context =>
            {
                return menuRepository.AddMenu(context.GetArgument<Menu>("menu"));

            });

            Field<StringGraphType>("DeleteMenu").Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "menuId" })).Resolve(context =>
            {
                menuRepository.DeleteMenu(context.GetArgument<int>("menuId"));
                return "menu Deleted  for ID" + context.GetArgument<int>("menuId");

            });

            Field<MenuType>("UpdateMenu").Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "menuId" },
                new QueryArgument<MenuInputType> { Name = "menu" })).Resolve(context =>
            {
                return menuRepository.UpdateMenu(context.GetArgument<int>("menuId"), context.GetArgument<Menu>("menu"));

            });
        }
    }
}
