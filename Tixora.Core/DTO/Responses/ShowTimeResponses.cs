using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tixora.Core.DTO.Responses
{
    public class ShowTimeResponse
    {
        public int ShowtimeID { get; set; }
        public int MovieID { get; set; }
        public DateTime ShowDate { get; set; }
        public TimeSpan ShowTime { get; set; }
        public int AvailableSeats { get; set; }
        public bool IsActive { get; set; }
    }

    public class ShowTimeWithMovieResponse : ShowTimeResponse
    {
        public MovieResponse Movie { get; set; }
    }
}
