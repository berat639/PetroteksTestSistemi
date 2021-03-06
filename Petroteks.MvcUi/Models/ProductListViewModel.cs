﻿using System.Collections.Generic;
using Petroteks.Entities.Concreate;

namespace Petroteks.MvcUi
{
    public class ProductListViewModel
    {
        public ICollection<Product> Products { get; set; }
        public ICollection<Category> SubCategories { get; internal set; }

        public Category CurrentCategory { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }
        public int PageSize { get; set; }
    }
}