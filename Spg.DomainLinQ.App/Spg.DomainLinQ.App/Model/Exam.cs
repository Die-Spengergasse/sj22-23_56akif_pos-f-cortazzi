using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// * Date (?)
    /// * Lesson (int?)
    /// * Created
    /// * Guid
    /// * Grade (Note 1-5)
    /// (4P)
    /// </summary>
    public class Exam : EntityBase
    {
  

        public DateTime? Date { get; set; } = new();
        public int? Lesson { get; set; } = new();
        public DateTime Created { get; set; } = new();
        public string Guid { get; set; } = string.Empty;
        public int Grade { get; set; } = new();
        protected Exam() { }
        public Exam(string guid, DateTime? date, int? lesson, int grade,DateTime created)
        {
            Date = date;
            Lesson = lesson;
            Created = created;
            Guid = guid;
            Grade = grade;
        }
    }
}
