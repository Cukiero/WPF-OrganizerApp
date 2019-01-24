using DesktopProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopProject.Data
{
    public class DayPlansDao
    {
        public string FilePath { get; set; } = "C:\\Users\\Cukier\\Documents\\My Projects\\WPF-OrganizerApp\\DesktopProject\\Data\\XmlStorage\\DayPlans.xml";
        public ObservableCollection<DayPlan> DayPlans { get; set; }

        public DayPlansDao()
        {
            DayPlans = (XmlHelper.LoadDataFromFile<DayPlan>(FilePath));
        }

        private void InsertInCorrectOrder(DayPlan dayPlan)
        {
            var result = DayPlans.Select((Value, Index) => new { Value, Index }).FirstOrDefault(x => x.Value.Date < dayPlan.Date);
            
            if(result == null)
            {
                DayPlans.Add(dayPlan);
            }
            else
            {
                DayPlans.Insert(result.Index, dayPlan);
            }
            
        }
        public void AddDayPlan(DayPlan dayPlan)
        {
            string newId;
            do
            {
                newId = Guid.NewGuid().ToString("n");
            }
            while (DayPlans.FirstOrDefault(x => x.Id == newId) != null);

            dayPlan.Id = newId;

            foreach(Activity activity in dayPlan.Activities)
            {
                string newActivityId;
                do
                {
                    newActivityId = Guid.NewGuid().ToString("n");
                }
                while (dayPlan.Activities.FirstOrDefault(x => x.Id == newActivityId) != null);

                activity.Id = newActivityId;
            }

            InsertInCorrectOrder(dayPlan);

            XmlHelper.SaveDataToFile<DayPlan>(FilePath, this.DayPlans);
        }

        public void AddDayPlanActivity(Activity activity, string dayPlanId)
        {
            DayPlan dayPlan = DayPlans.FirstOrDefault(x => x.Id == dayPlanId);

            if (dayPlan != null)
            {
                string newId;
                do
                {
                    newId = Guid.NewGuid().ToString("n");
                }
                while (dayPlan.Activities.FirstOrDefault(x => x.Id == newId) != null);

                activity.Id = newId;

                dayPlan.Activities.Add(activity);

                XmlHelper.SaveDataToFile<DayPlan>(FilePath, this.DayPlans);
            }
            
        }

        public void RemoveDayPlanActivity(string dayPlanId, string activityId)
        {
            DayPlan dayPlan = DayPlans.FirstOrDefault(x => x.Id == dayPlanId);

            if (dayPlan != null)
            {
                Activity activity = dayPlan.Activities.FirstOrDefault(x => x.Id == activityId);
                
                if(activity != null)
                {
                    dayPlan.Activities.Remove(activity);
                    XmlHelper.SaveDataToFile<DayPlan>(FilePath, this.DayPlans);
                }
            }

        }
        public void RemoveDayPlan(string id)
        {
            DayPlans.Remove(DayPlans.FirstOrDefault(x => x.Id == id));

            XmlHelper.SaveDataToFile<DayPlan>(FilePath, this.DayPlans);
        }
    }
}
