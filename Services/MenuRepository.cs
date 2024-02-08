using Microsoft.EntityFrameworkCore;
using NewGraphQL.Data;
using NewGraphQL.Interfaces;
using NewGraphQL.Model;

namespace NewGraphQL.Services
{
    public class MenuRepository : IMenuRepository
    {
        private GraphQLDbContext dbContext;

        public MenuRepository(GraphQLDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Menu AddMenu(Menu menu)
        {
            dbContext.Menus.Add(menu);
            dbContext.SaveChanges();
            return menu;
        }

        public void DeleteMenu(int id)
        {
            var menuResult = dbContext.Menus.Find(id);
            dbContext.Menus.Remove(menuResult);
            dbContext.SaveChanges();
        }

        public List<Menu> GetAllMenu()
        {
            return dbContext.Menus.ToList();
        }

        public Menu GetMenuById(int id)
        {
            return dbContext.Menus.Find(id);
        }

        public Menu UpdateMenu(int id, Menu menu)
        {
            var menuResult = dbContext.Menus.Find(id);
            menuResult.Description = menu.Description;
            menuResult.Name = menu.Name;
            menuResult.Price = menu.Price;
            dbContext.SaveChanges();

            return menu;
        }
    }
}
