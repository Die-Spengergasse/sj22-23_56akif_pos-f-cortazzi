using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// * FirstName
    /// * LastName
    /// * EMail
    /// * Address
    /// * Gender
    /// * Guid
    /// (4P)
    /// </summary>
    public class Teacher : EntityBase
    {

        public string Guid { get; private set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string EMail { get; set; } = string.Empty;
        public Address Address { get; set; } = default!;
        public Gender Gender { get; set; }

        private List<Subject> _subjects = new();
        public IReadOnlyList<Subject> Subjetcts => _subjects;
        protected Teacher() { }

        public Teacher(string guid, string firstName, string lastName, string eMail, Address address, Gender gender)
        {
            Guid = guid;
            FirstName = firstName;
            LastName = lastName;
            EMail = eMail;
            Address = address;
            Gender = gender;
        }

        public void AddSubject(Subject subject)
        {
            _subjects.Add(subject);
        }
    }
}
