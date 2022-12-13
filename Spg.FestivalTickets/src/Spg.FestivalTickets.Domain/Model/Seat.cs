using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.FestivalTickets.Domain.Model
{ 

    //public enum Category {a, b, c, d, e, f};
    public class Seat
    {
        public int SeatNumber { get; set; }
        public Event Events { get; set; } = default!;
        public Category SeatCategory { get; set; } = default!;
    }
}
