﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce_App.Models
{
    public class MealsByCategory
    {
        public string MealName { get; set; }
        public List<Meal> Meals  { get; set; } 
    }
}
