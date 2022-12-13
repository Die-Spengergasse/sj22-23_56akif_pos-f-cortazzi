using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.FestivalTickets.Domain.Model
{
    public class Event
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; }    = string.Empty;
        public string Programme { get; set; } = string.Empty;
        public List<Artist> Artists { get; set; } = new();
        public Location Locations { get; set; } = default!;
        public List<Category> Categories { get; set; } = new();   
        public DateTime Date { get; set; }
    }
}
