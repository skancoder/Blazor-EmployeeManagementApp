﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer.Pages
{
    public partial class Counter
    {
        private int currentCount = 0;
        private string fontFamily = "Verdana";

        private void IncrementCount()
        {
            currentCount++;
        }
    }
}
