using DesktopProject.Data;
using DesktopProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for Notes.xaml
    /// </summary>
    public partial class NotesPage : UserControl
    {
        private ObservableCollection<Note> Notes { get; set; } = new ObservableCollection<Note>();
        private NotesDao notesDao = new NotesDao();

        private static NotesPage instance;

        public static NotesPage Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new NotesPage();
                }
                return instance;
            }
        }
        public NotesPage()
        {
            InitializeComponent();
            NotesList.ItemsSource = Notes;
            UpdateNoteCollection();
        }

        private void AddNote(Note note)
        {
            notesDao.AddNote(note);
            UpdateNoteCollection();
        }

        private void RemoveNote(string id)
        {
            notesDao.RemoveNote(id);
            UpdateNoteCollection();
        }

        private void UpdateNoteCollection()
        {
            Notes.Clear();
            foreach(Note note in notesDao.GetNotes())
            {
                Notes.Add(note);
            }
        }

        private void ShowNewNoteDialogButton_Click(object sender, RoutedEventArgs e)
        {
            AddNoteModal modalWindow = new AddNoteModal();
            modalWindow.HorizontalAlignment = HorizontalAlignment.Center;
            modalWindow.VerticalAlignment = VerticalAlignment.Center;
            modalWindow.ShowDialog();

            Note newNote = new Note()
            {
                Title = modalWindow.NewNoteTitle,
                Content = modalWindow.NewNoteContent
            };

            if(String.IsNullOrEmpty(newNote.Title) || String.IsNullOrEmpty(newNote.Content))
            {
                return;
            }
            else
            {
                AddNote(newNote);
            }
        }

        public void ShowRemoveNoteDialogButton_Click(object sender, RoutedEventArgs e)
        {
            string noteId = (string)((Button)sender).Tag;

            RemoveItemModal modalWindow = new RemoveItemModal();
            modalWindow.HorizontalAlignment = HorizontalAlignment.Center;
            modalWindow.VerticalAlignment = VerticalAlignment.Center;
            modalWindow.ShowDialog();

            if (modalWindow.Confirmed)
            {
                RemoveNote(noteId);
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
