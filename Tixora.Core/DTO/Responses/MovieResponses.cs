using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tixora.Core.DTO.Responses
{
    public class MovieResponse
    {
        public int MovieID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Duration { get; set; }
        public string Language { get; set; }
        public string Format { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public string TrailerURL { get; set; }
        public string PosterURL { get; set; }
        public bool IsActive { get; set; }
    }
}
