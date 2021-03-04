using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MaintenanceApp
{
    public class Task : INotifyPropertyChanged
    {
        public int Task_ID { get; set; }
        public int Room_ID { get; set; }
        public string Task_Type { get; set; }
        public string Task_Note { get; set; }
        public string Status { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
