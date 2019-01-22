using DesktopProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopProject.Data
{
    public class NotesDao
    {
        public string FilePath { get; set; } = "C:\\Users\\Cukier\\source\\repos\\DesktopProject\\DesktopProject\\Data\\XmlStorage\\Notes.xml";
        private List<Note> Notes { get; set; }

        public NotesDao()
        {
            Notes = XmlHelper.LoadDataFromFile<Note>(FilePath);
        }

        public List<Note> GetNotes()
        {
            return Notes;
        }

        public void AddNote(Note note)
        {
            string newId;
            do
            {
                newId = Guid.NewGuid().ToString("n");
            }
            while (Notes.Find(x => x.Id == newId) != null);

            note.Id = newId;

            Notes.Insert(0, note);

            XmlHelper.SaveDataToFile<Note>(FilePath, this.Notes);
        }

        public void RemoveNote(string id)
        {
            Notes.Remove(Notes.Find(x => x.Id == id));

            XmlHelper.SaveDataToFile<Note>(FilePath, this.Notes);
        }
    }
}
