using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintenanceApp
{
    public class Task
    {
        public int Room_ID { get; set; }
        public int Task_ID { get; set; }
        public string Status { get; set; }
    }
    public class Task_Type
    {
        public int Task_ID { get; set; }
        public int Post_ID { get; set; }
        public string Type { get; set; }
    }
}
