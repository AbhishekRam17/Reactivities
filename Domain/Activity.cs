using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Activity
    {

        public Guid Id { get; set; }

        public String Title { get; set; }

        public DateTime Date { get; set; }

        public String Description { get; set; }

        public String Category { get; set; }

        public string Venue { get; set; }

        public string City  { get; set; }
    }
}
