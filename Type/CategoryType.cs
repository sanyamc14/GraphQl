using GraphQL.Types;
using NewGraphQL.Interfaces;
using NewGraphQL.Model;
using NewGraphQL.Services;

namespace NewGraphQL.Type
{
    public class CategoryType : ObjectGraphType<Category>
    {
        public CategoryType(IMenuRepository menuRepository) 
        {
            Field(c => c.Id);
            Field(c => c.ImageUrl);
            Field(c => c.Name);

            Field<ListGraphType<MenuType>>("Menus").Resolve(context =>
            {
                return menuRepository.GetAllMenu();

            });
        }
    }
}
