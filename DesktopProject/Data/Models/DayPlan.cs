using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopProject.Data.Models
{
    public class DayPlan : BaseModel
    {
        private string id;
        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                NotifyPropertyChanged("Id");
            }
        }

        private DateTime date;
        public DateTime Date {
            get
            {
                return date.Date;
            }
            set
            {
                date = value.Date;
                NotifyPropertyChanged("Date");
            }
        }
        public ObservableCollection<Activity> Activities { get; set; } = new ObservableCollection<Activity>();
        

    }
}
