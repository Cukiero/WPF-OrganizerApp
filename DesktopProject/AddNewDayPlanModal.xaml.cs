using DesktopProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DesktopProject
{
    /// <summary>
    /// Interaction logic for AddNewDayPlanModal.xaml
    /// </summary>
    public partial class AddNewDayPlanModal : Window
    {
        public DayPlan NewDayPlan { get; set; } = new DayPlan();
        public bool AddButtonPressed = false;
        public AddNewDayPlanModal()
        {
            InitializeComponent();
            DayActivitiesList.ItemsSource = NewDayPlan.Activities;
        }

        private void AddNewDayPlanButton_Click(object sender, RoutedEventArgs e)
        {
            NewDayPlan.Date = (DateTime)DatePicker.SelectedDate;
            if (NewDayPlan.Date != null)
            {

                AddButtonPressed = true;
            }
            
            this.Close();
        }

        private void AddActivityButton_Click(object sender, RoutedEventArgs e)
        {
            string tempId;
            do
            {
                tempId = Guid.NewGuid().ToString("n");
            }
            while (NewDayPlan.Activities.FirstOrDefault(x => x.Id == tempId) != null);
            
            NewDayPlan.Activities.Add(new Activity()
            {
                Id = tempId,
                Description = NewActivityDescBox.Text
            });
        }

        private void RemoveNewDayActivityDialogButton_Click(object sender, RoutedEventArgs e)
        {
            Activity toRemove = NewDayPlan.Activities.FirstOrDefault(x => x.Id == (string)((Button)sender).Tag);

            if(toRemove != null)
            {
                NewDayPlan.Activities.Remove(toRemove);
            }
        }
    }
}
