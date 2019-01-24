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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            ContentPanel.Children.Clear();
            ContentPanel.Children.Add(HomeTab.Instance);
        }

        public void NotesButton_Click(object sender, RoutedEventArgs e)
        {
            ContentPanel.Children.Clear();
            ContentPanel.Children.Add(NotesTab.Instance);
        }

        public void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            ContentPanel.Children.Clear();
            ContentPanel.Children.Add(HomeTab.Instance);
        }

        public void EventsButton_Click(object sender, RoutedEventArgs e)
        {
            ContentPanel.Children.Clear();
            ContentPanel.Children.Add(DayPlansTab.Instance);
        }
    }
}
