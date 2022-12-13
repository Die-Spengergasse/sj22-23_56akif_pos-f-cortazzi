using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.FestivalTickets.Domain.Model
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}
