using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.FestivalTickets.Domain.Model
{
    public class Artist
    {
        public string ArtistNumber { get; init; } = string.Empty;
        public string ArtistName { get; set; } = string.Empty ;
        public string EMail { set; get; } = string.Empty;
        public string PhoneNumber { set; get; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public List<Event> Events { set; get; } = new();
        public decimal Fee { set; get; }
    }
}
