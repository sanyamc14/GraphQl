﻿using GraphQL.Types;
using NewGraphQL.Model;

namespace NewGraphQL.Type
{
    public class MenuType : ObjectGraphType<Menu>
    {
        public MenuType() 
        {
            Field(m => m.Id);
            Field(m => m.Name);
            Field(m => m.Description);
            Field(m => m.Price);
            Field(m => m.ImageUrl);
            Field(m => m.CategoryId);

        }
       
    }
}