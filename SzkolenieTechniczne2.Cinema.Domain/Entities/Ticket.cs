using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using SzkolenieTechniczne2.Cinema.Common.Entities;

namespace SzkolenieTechniczne2.Cinema.Domain.Entities
{
    [Table("Tickets", Schema = "Cinema")]
    public class Ticket : BaseEntity
    {
        protected Ticket() { }

        public Ticket(string name, DateTime purchaseDate, int peopleCount)
        {
            Email = name;
            PeopleCount = peopleCount;
            PurchaseDate = DateTime.UtcNow;
        }

        public string Email { get; protected set; }
        public DateTime PurchaseDate { get; protected set; }
        public int PeopleCount { get; protected set; }

        private static List<Ticket> Tickets = new List<Ticket>();

        public static List<Ticket> GetTicketByEmail(string email)
        {
            return Tickets.Where(ticket => ticket.Email == email).ToList();
        }

        public static List<Ticket> GetAllSeanceTickets()
        {
            return Tickets.ToList();
        }

        public static void Add(Ticket ticket)
        {
            Tickets.Add(ticket);
        }
    }
}
