using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.FestivalTickets.Domain.Model
{
    public class Location
    {
        public int Id { get; init; }
        public int MaxSeats { get; set; }
        public List<Seat> Seats { get; set; } = default!;
        public string Address { get; set; } = string.Empty;

    }
}
