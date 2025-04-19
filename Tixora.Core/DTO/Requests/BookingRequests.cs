using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tixora.Core.DTO.Requests
{
    public class CreateBookingRequest
    {
        public int UserID { get; set; }
        public int ShowtimeID { get; set; }
        public int MovieID { get; set; }
        public int TicketCount { get; set; }
    }
}
