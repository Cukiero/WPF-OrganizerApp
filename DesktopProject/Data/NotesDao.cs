using DesktopProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DesktopProject.Data
{
    public class NotesDao
    {
        public string FilePath { get; set; } = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Notes.xml");
        public ObservableCollection<Note> Notes { get; set; }

        public NotesDao()
        {
            Notes = XmlHelper.LoadDataFromFile<Note>(FilePath);
        }

        public void AddNote(Note note)
        {
            string newId;
            do
            {
                newId = Guid.NewGuid().ToString("n");
            }
            while (Notes.FirstOrDefault(x => x.Id == newId) != null);

            note.Id = newId;

            Notes.Insert(0, note);

            XmlHelper.SaveDataToFile<Note>(FilePath, this.Notes);
        }

        public Note GetNoteById(string id)
        {
            return Notes.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateNote(Note note)
        {
            Note noteToEdit = Notes.FirstOrDefault(x => x.Id == note.Id);

            if(noteToEdit != null)
            {
                noteToEdit.Title = note.Title;
                noteToEdit.Content = note.Content;
            }

            XmlHelper.SaveDataToFile<Note>(FilePath, this.Notes);
        }

        public void RemoveNote(string id)
        {
            Notes.Remove(Notes.FirstOrDefault(x => x.Id == id));

            XmlHelper.SaveDataToFile<Note>(FilePath, this.Notes);
        }
    }
}
