﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestraunt.Entities.DTOs
{
    #region Category
    public class Category
    {
        public string Description { get; set; }
        public IEnumerable<MenuItem> MenuItems { get; set; }
    }
    #endregion
}
