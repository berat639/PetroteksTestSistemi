﻿using System.Collections.Generic;
using Petroteks.Entities.Concreate;

namespace Petroteks.MvcUi.Models
{
    public class MainPageViewModel
    {
        public MainPage MainPage { get; set; }
        public ICollection<Blog> Blogs { get; set; }
        public ICollection<Category> Categories { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
