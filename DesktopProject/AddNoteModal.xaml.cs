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
    /// Interaction logic for AddNoteModal.xaml
    /// </summary>
    public partial class AddNoteModal : Window
    {
        public string NewNoteTitle { get; set; }
        public string NewNoteContent { get; set; }
        public AddNoteModal()
        {
            InitializeComponent();
        }

        private void AddNoteButton_Click(object sender, RoutedEventArgs e)
        {
            NewNoteTitle = TitleBox.Text;
            NewNoteContent = ContentBox.Text;
            this.Close();
        }
    }
}
