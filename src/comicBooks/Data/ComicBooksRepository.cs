using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using comicBooks.Models; 

namespace comicBooks.Data
{
    public class ComicBooksRepository
    {
        private static ComicBooks[] _comicBooks = new ComicBooks[]
        {
            new ComicBooks()
            {
                Id = 1,
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artists[]
               {
                    new Artists() { Name="Dan Slott",Role="Script" },
                    new Artists() { Name="Humberto Ramos",Role="Pencils" },
                    new Artists() { Name="Victor Olazaba",Role="Inks" },
                    new Artists() { Name="Edgar Delgado",Role="Colors" },
                    new Artists() { Name="Chris Eliopoulos",Role="Letters" },
               }
            },
            new ComicBooks()
            {
                Id = 2,
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
                Artists = new Artists[]
                {
                    new Artists() { Name = "Dan Slott", Role = "Script" },
                    new Artists() { Name = "Humberto Ramos", Role = "Pencils" },
                    new Artists() { Name = "Victor Olazaba", Role = "Inks" },
                    new Artists() { Name = "Edgar Delgado", Role = "Colors" },
                    new Artists() { Name = "Chris Eliopoulos", Role = "Letters" },
                },
                Favorite = false
            },
    //new ComicBooks()
    //{
    //    SeriesTitle = "The Amazing Spider-Man",
    //    IssueNumber = 657,
    //    DescriptionHtml = "<p><strong>FF: THREE TIE-IN.</strong> Spider-Man visits the FF for a very private wake--just for family.</p>",
    //    Artists = new Artists[]
    //    {
    //        new Artists() { Name = "Dan Slott", Role = "Script" },
    //        new Artists() { Name = "Marcos Martin", Role = "Pencils" },
    //        new Artists() { Name = "Marcos Martin", Role = "Inks" },
    //        new Artists() { Name = "Muntsa Vicente", Role = "Colors" },
    //        new Artists() { Name = "Joe Caramagna", Role = "Letters" }
    //    },
    //        Favorite = false
    //    },
        new ComicBooks()
        {
            Id = 3,
            SeriesTitle = "Bone",
            IssueNumber = 50,
            DescriptionHtml = "<p><strong>The Dungeon & The Parapet, Part 1.</strong> Thorn is discovered by Lord Tarsil and the corrupted Stickeaters and thrown into a dungeon with Fone Bone. As she sleeps, a message comes to her about the mysterious \"Crown of Horns\".</p>",
            Artists = new Artists[]
            {
                new Artists() { Name = "Jeff Smith", Role = "Script" },
                new Artists() { Name = "Jeff Smith", Role = "Pencils" },
                new Artists() { Name = "Jeff Smith", Role = "Inks" },
                new Artists() { Name = "Jeff Smith", Role = "Letters" }
            },
            Favorite = false
        }
    };
           
    
    
        public ComicBooks[] GetComicBooks()
        {
            return _comicBooks;
        }

        public ComicBooks GetComicBook(int id)
        {
            ComicBooks comicBookToReturn = null;
            foreach (var comicBook in _comicBooks)
            {
                if (comicBook.Id == id)
                {
                    comicBookToReturn = comicBook;

                    break;
                }
            }
            return comicBookToReturn; 
        }
        
    }
}