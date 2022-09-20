using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp_Basics_HW.Enums;

namespace CSharp_Basics_HW.Models
{
    internal struct Task
    {
        public string TaskId { get; set; }
        public string TaskName { get; set; }
        public DateTime DateOfCreation { get; set; }
        public DateTime DateOfEfectuation{ get; set; }
        public string Description { get; set; }
        public TaskPriority TaskPriority { get; set; }
        public bool State { get; set; }
        public bool IsAssigned { get; set; }

    }
}
