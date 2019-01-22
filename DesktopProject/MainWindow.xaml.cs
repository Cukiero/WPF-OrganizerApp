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
        private UserControl currentView;
        public UserControl CurrentView {
            get { return currentView; }
            set
            {
                currentView = value;
            }
        }
        

        public MainWindow()
        {
            InitializeComponent();
        }

        public void NotesButton_Click(object sender, RoutedEventArgs e)
        {
            ContentPanel.Children.Clear();
            ContentPanel.Children.Add(NotesPage.Instance);
        }

        public void ListsButton_Click(object sender, RoutedEventArgs e)
        {

        }

        public void EventsButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
