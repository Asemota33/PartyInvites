using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Comp229PartyInvites.Models
{
    public class Repository
    {
        public static List<GuestResponse> Responses = new List<GuestResponse>();

        public static IEnumerable<GuestResponse> responses
        {
            get { return Responses; }
        }

        public static void AddResponse(GuestResponse response)
        {
            Responses.Add(response);
        }
    }
}
