﻿using comicBooks.Data;
using comicBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace comicBooks.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBooksRepository _comicBooksRepository = null;

        public ComicBooksController()
        {
            _comicBooksRepository = new ComicBooksRepository();
        }

        public ActionResult Index()
        {
            var comicBooks = _comicBooksRepository.GetComicBooks();

            return View(comicBooks);
        }

        public ActionResult Detail(int? id)
        {
            //var comicBook = new ComicBooks()
            //{
            //    SeriesTitle = "The Amazing Spider-Man",
            //    IssueNumber = 700,
            //    DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
            //    Artists = new Artists[]
            //    {
            //        new Artists() { Name="Dan Slott",Role="Script" },
            //        new Artists() { Name="Humberto Ramos",Role="Pencils" },
            //        new Artists() { Name="Victor Olazaba",Role="Inks" },
            //        new Artists() { Name="Edgar Delgado",Role="Colors" },
            //        new Artists() { Name="Chris Eliopoulos",Role="Letters" },
            //    }
            //};
        if(id == null)
            {
                return HttpNotFound();
            }

            var comicBook = _comicBooksRepository.GetComicBook(id.Value);

           return View(comicBook);
        }
    }
} 