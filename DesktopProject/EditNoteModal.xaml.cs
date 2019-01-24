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
    /// Interaction logic for EditNoteModal.xaml
    /// </summary>
    public partial class EditNoteModal : Window
    {
        public string NewTitle { get; set;}
        public string NewContent { get; set; }
        public bool EditButtonPressed { get; set; } = false;
        public EditNoteModal(string title, string content)
        {
            InitializeComponent();
            TitleBox.Text = title;
            ContentBox.Text = content;
        }

        private void EditNoteButton_Click(object sender, RoutedEventArgs e)
        {
            NewTitle = TitleBox.Text;
            NewContent = ContentBox.Text;

            EditButtonPressed = true;

            this.Close();
        }
    }
}
