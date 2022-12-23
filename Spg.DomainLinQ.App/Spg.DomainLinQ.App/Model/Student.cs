using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// * RegistrationNumber
    /// * FirstName
    /// * LastName
    /// * EMail
    /// * Address
    /// * PhoneNumber
    /// * AccountName = [Die ersten 5 Stellen des LastName + RegistrationNumber]
    /// * Gender
    /// * Guid
    /// (4P)s
    /// </summary>
    public class Student : EntityBase
    {
        public int RegistrationNumber { get; private set; } = new();
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string EMail { get; set; } = string.Empty;
        public Address Address { get; set; } = default!;
        public PhoneNumber PhoneNumber { get; set; } = default!;
        public string AccountName => $"{LastName.Substring(0, 4)} + {RegistrationNumber}";
        public Gender Gender { get; set; } = default!;
        public string Guid { get; set; } = string.Empty;
        private List<Subject> _subjects = new();
        public IReadOnlyList<Subject> Subjects => _subjects;
        protected Student() { }

        public Student(int registrationNumber,
            string guid,
            string firstName,
            string lastName,
            string eMail,
            Gender gender,
            Address address,
            List<Subject> subjects,
            PhoneNumber phoneNumber)
        {
            RegistrationNumber = registrationNumber;
            FirstName = firstName;
            LastName = lastName;
            EMail = eMail;
            Address = address;
            PhoneNumber = phoneNumber;
            Gender = gender;
            Guid = guid;
            _subjects = subjects;
        }

        public void AddSubjects(List<Subject> subjects)
        {
            _subjects.AddRange(subjects);
        }
    }
}
