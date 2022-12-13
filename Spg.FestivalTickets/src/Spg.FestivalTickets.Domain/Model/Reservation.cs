using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.FestivalTickets.Domain.Model
{
    public enum PaymentMethods { Creditcard, Debitcard, Paypal, Cash}
    public class Reservation
    {
        public string Id { get; set; } = string.Empty;
        public int ItemsCount { get; set; }
        public Customer CustomerNavigation { get; set; } = default!; // gehoert einem Customer, Information wird von der Datenbank erhalten - default! = null;
        public List<Seat> Seats { get; set; } = new();
        public List<Event> Events { get; set; } = new();
        public PaymentMethods PaymentMethod { get; set; }
        public DateTime DateOfPayment { get; set; }
    }
}
