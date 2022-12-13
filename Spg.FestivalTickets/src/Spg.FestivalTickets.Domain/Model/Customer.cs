using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.FestivalTickets.Domain.Model
{

    public enum Genders { Male, Female, Other}
    public enum Languages { German, English, Spanish}
    public enum Newsletters { Online, Mail, None }
    public class Customer
    {
        public Genders Gender { get; set; }
        public string CustomerNumber { get; init; }  = string.Empty; 
        public string FirstName { set; get; } = string.Empty;
        public string LastName { set; get; } = string.Empty;
        public string EMail { set; get; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public Languages Language { get; set; } = Languages.German;
        public Newsletters Newsletter { get; set; } = Newsletters.Online; 
        public List<Reservation> Reservations { get; set; } = new();
        public string Password { get; set; } = string.Empty ;   
    }
}
