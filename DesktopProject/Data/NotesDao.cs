﻿using DesktopProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopProject.Data
{
    public class NotesDao
    {
        public string FilePath { get; set; } = "C:\\Users\\Cukier\\Documents\\My Projects\\WPF-OrganizerApp\\DesktopProject\\Data\\XmlStorage\\Notes.xml";
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
        }

        public void RemoveNote(string id)
        {
            Notes.Remove(Notes.FirstOrDefault(x => x.Id == id));

            XmlHelper.SaveDataToFile<Note>(FilePath, this.Notes);
        }
    }
}
