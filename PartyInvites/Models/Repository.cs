using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public static class Repository
    {
        private static List<GuesstResponse> responses = new List<GuesstResponse>();
        
        public static IEnumerable<GuesstResponse> Responses
        {
            get { return responses; }
        }

        public static void AddResponse(GuesstResponse response)
        {
            responses.Add(response);
        }
            
            
    }
}
