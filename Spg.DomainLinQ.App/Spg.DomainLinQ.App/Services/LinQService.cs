using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.Extensions.Options;
using Spg.DomainLinQ.App.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Services
{
    /// <summary>
    /// (8P)
    /// </summary>
    public class LinQService
    {
        private readonly LinQServices _db;
        public LinQService(LinQServices db)
        {
            _db = db;
        }
        DbContextOptionsBuilder optionsBuilder = new DbContextOptionsBuilder();
        optionsBuilder.UseSqlite("Data Source=C:\\POS\\School2000.db");

        LinQServices db = new LinQService(optionsBuilder.Options);
        public void Start()
        {

            // Gebe jenen Student mit der ID=12 zurück.
            var result01 = db.Students.Where(s => s.Id == 12).SingleOrDefault();

            // Erstelle eine Liste aller Fächer, die eine negative Note haben.
            var result02 = db.Exams.Any(g => g.Grade.Equals(5));

            // Erstelle eine Liste aller Fächer, die eine negative Note in POS haben.
            var result03 = db.Exams.Any(g => g.Grade.Equals(5) && g.Lesson.Equals("POS"));

            // Erstelle eine Liste aller Fächer, die nur positive Noten haben.
            var result04 = db.Exams.Any(g => !g.Grade.Equals(5));

            // Erstelle eine Liste aller Lehrer, die POS unterrichten
            var result05 = db.Teachers.Where(t => t.Subjetcts.Equals("POS"));

            // Erstelle eine Liste aller Students mit einer "hotmail"-E-Mail-Adresse
            var result06 =  db.Students.Where(s => s.EMail.EndsWith("hotmail.com"));

            // Ermittle die schlechteste Note im Fach POS
            var result07 = db.Exams.Max(g => g.Grade);

            // Ermittle den Notendurchschnitt im Fach DBI
            var result08 = db.Exams.Where(e => e.Lesson.Equals("DBI")).Average(g => g.Grade);
        }
    }
}
