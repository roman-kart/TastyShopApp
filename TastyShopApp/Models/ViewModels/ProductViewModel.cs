﻿using Microsoft.AspNetCore.Mvc.Rendering;

namespace TastyShopApp.Models.ViewModels
{
    public class ProductViewModel
    {
        public Product Product { get; set; }
        public IEnumerable<SelectListItem> CategorySelectList { get; set; }
        public IEnumerable<SelectListItem> ManagerSelectList { get; set; }
    }
}
