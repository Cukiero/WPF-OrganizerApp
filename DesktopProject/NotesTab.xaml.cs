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
    public partial class NotesTab : UserControl
    {
        private NotesDao notesDao = new NotesDao();

        private static NotesTab instance;

        public static NotesTab Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new NotesTab();
                }
                return instance;
            }
        }
        public NotesTab()
        {
            InitializeComponent();
            NotesList.ItemsSource = notesDao.Notes;
        }

        private void AddNote(Note note)
        {
            notesDao.AddNote(note);
        }

        private void RemoveNote(string id)
        {
            notesDao.RemoveNote(id);
        }

        private void ShowNewNoteDialogButton_Click(object sender, RoutedEventArgs e)
        {
            AddNoteModal modalWindow = new AddNoteModal();
            modalWindow.HorizontalAlignment = HorizontalAlignment.Center;
            modalWindow.VerticalAlignment = VerticalAlignment.Center;
            modalWindow.Owner = MainWindow.GetWindow(this);
            modalWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
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
            modalWindow.Owner = MainWindow.GetWindow(this);
            modalWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            modalWindow.ShowDialog();

            if (modalWindow.Confirmed)
            {
                RemoveNote(noteId);
            }
        }
        private void ShowEditNoteDialogButton_Click(object sender, RoutedEventArgs e)
        {
            string noteId = (string)((Button)sender).Tag;

            Note noteToEdit = notesDao.GetNoteById(noteId);

            if(noteToEdit != null)
            {
                EditNoteModal modalWindow = new EditNoteModal(noteToEdit.Title, noteToEdit.Content);
                modalWindow.HorizontalAlignment = HorizontalAlignment.Center;
                modalWindow.VerticalAlignment = VerticalAlignment.Center;
                modalWindow.Owner = MainWindow.GetWindow(this);
                modalWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                modalWindow.ShowDialog();

                if (modalWindow.EditButtonPressed)
                {
                    if (String.IsNullOrEmpty(modalWindow.NewTitle) || String.IsNullOrEmpty(modalWindow.NewContent))
                    {
                        return;
                    }
                    else
                    {
                        noteToEdit.Title = modalWindow.NewTitle;
                        noteToEdit.Content = modalWindow.NewContent;

                        notesDao.UpdateNote(noteToEdit);
                    }
                }
            }
        }
    }
}
