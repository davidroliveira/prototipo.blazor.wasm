using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace WebApplication1.Pages
{
    public partial class Counter
    {
        private int currentCount = 0;

        [Parameter]
        public int Incremento { get; set; } = 1;

        private void IncrementCount()
        {
            currentCount += Incremento;
        }
    }
}
