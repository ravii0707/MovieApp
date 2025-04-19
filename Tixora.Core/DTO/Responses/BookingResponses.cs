using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tixora.Core.DTO.Responses
{
    public class BookingResponse
    {
        public int BookingID { get; set; }
        public int UserID { get; set; }
        public int ShowtimeID { get; set; }
        public int MovieID { get; set; }
        public int TicketCount { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime BookingDate { get; set; }
    }

    public class BookingDetailsResponse : BookingResponse
    {
        public UserResponse User { get; set; }
        public ShowTimeResponse ShowTime { get; set; }
        public MovieResponse Movie { get; set; }
    }
}
