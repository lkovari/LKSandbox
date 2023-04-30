using LKSandbox.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKSandbox.Models
{
    internal class TotalCostData : ITotalCostData
    {
        public decimal TotalCost { get; }
        public TotalCostData(decimal totalCost) {
            this.TotalCost = totalCost; 
        }
    }
}
