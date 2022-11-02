﻿using Entities.Concrete;

namespace WebUI.ViewModels
{
    public class HomeVM
    {
        public List<Category> Categories { get; set; }
        public List<Product> PopularProducts { get; set; }
        public List<Product> RecentProducts { get; set; }
    }
}
