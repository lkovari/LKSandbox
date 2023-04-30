using LKSandbox.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKSandbox.Models
{
    internal class ApprovementData : IApprovementData
    {
        public DateOnly Date { get; }

        public bool IsApproved { get; }
        
        public ApprovementData(DateOnly date, bool approved) {
            Date = date;
            IsApproved = approved;
        }
    }
}
