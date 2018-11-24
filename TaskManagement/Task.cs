using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement
{
    public class Task
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Details { get; set; }
        public DateTime Date { get; set; }
        public string PlannedTime { get; set; }

        public Task()
        {
            Name = "";
            Type = "";
            Details = "";
            Date = DateTime.Now;
            PlannedTime = "";
        }
    }
}
