using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class NasaPotd
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Explanation { get; set; }
        public MediaType Media_Type { get; set; }
        public string Service_Version { get; set; }
        public string Title { get; set; }
        public string url { get; set; }
        public string hdurl { get; set; }
    }
}