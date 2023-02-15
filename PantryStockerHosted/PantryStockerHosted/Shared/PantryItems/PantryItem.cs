﻿using PantryStockerHosted.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PantryStockerHosted.Shared.PantryItems
{
    public class PantryItem
    {
        public string Name { get; set; }
        public double Amount { get; set; }
        public MeasuresEnum Measures { get; set; }

    }
    
}
