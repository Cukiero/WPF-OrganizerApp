using DesktopProject.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DesktopProject
{
    /// <summary>
    /// Interaction logic for DayPlansTab.xaml
    /// </summary>
    public partial class DayPlansTab : UserControl
    {
        private DayPlansDao dayPlansDao = new DayPlansDao();

        private static DayPlansTab instance;

        public static DayPlansTab Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DayPlansTab();
                }
                return instance;
            }
        }
        public DayPlansTab()
        {
            InitializeComponent();
            DaysList.ItemsSource = dayPlansDao.DayPlans;
            DaysList.SelectedItem = dayPlansDao.DayPlans.First();
        }

        private void ShowNewDayPlanDialogButton_Click(object sender, RoutedEventArgs e)
        {
            AddNewDayPlanModal modalWindow = new AddNewDayPlanModal();
            modalWindow.HorizontalAlignment = HorizontalAlignment.Center;
            modalWindow.VerticalAlignment = VerticalAlignment.Center;
            modalWindow.Owner = MainWindow.GetWindow(this);
            modalWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            modalWindow.ShowDialog();


            if (modalWindow.AddButtonPressed)
            {
                if(modalWindow.NewDayPlan.Date != null)
                {
                    dayPlansDao.AddDayPlan(modalWindow.NewDayPlan);
                }
            }

            modalWindow.Close();
        }

        private void AddSelectedDayActivityButton_Click(object sender, RoutedEventArgs e)
        {
            dayPlansDao.AddDayPlanActivity(new Activity() {
                Description = SelectedDayNewActivity.Text
            }, ((DayPlan)DaysList.SelectedItem).Id);
        }

        private void ShowRemoveDayDialogButton_Click(object sender, RoutedEventArgs e)
        {
            string dayId = (string)((Button)sender).Tag;

            RemoveItemModal modalWindow = new RemoveItemModal();
            modalWindow.HorizontalAlignment = HorizontalAlignment.Center;
            modalWindow.VerticalAlignment = VerticalAlignment.Center;
            modalWindow.Owner = MainWindow.GetWindow(this);
            modalWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            modalWindow.ShowDialog();

            if (modalWindow.Confirmed)
            {
                dayPlansDao.RemoveDayPlan(dayId);
            }
        }

        private void ShowRemoveCurrentDayAcctivityDialogButton_Click(object sender, RoutedEventArgs e)
        {
            RemoveItemModal modalWindow = new RemoveItemModal();
            modalWindow.HorizontalAlignment = HorizontalAlignment.Center;
            modalWindow.VerticalAlignment = VerticalAlignment.Center;
            modalWindow.Owner = MainWindow.GetWindow(this);
            modalWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            modalWindow.ShowDialog();

            if (modalWindow.Confirmed)
            {
                string activityId = (string)((Button)sender).Tag;
                string dayId = ((DayPlan)DaysList.SelectedItem).Id;
                dayPlansDao.RemoveDayPlanActivity(dayId, activityId);
            }
        }
    }
}
