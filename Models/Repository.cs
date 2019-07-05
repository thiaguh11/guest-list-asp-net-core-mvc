using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuestList.Models
{
    public static class Repository
    {
        private static List<Guest> Guests = new List<Guest>();

        public static void AddGuest(Guest g)
        {
            Guests.Add(g);
        }

        public static IEnumerable<Guest> AllGuest()
        {
            return Guests;
        }
    }
}
