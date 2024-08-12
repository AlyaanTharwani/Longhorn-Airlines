using System;
using spr24_team4_finalproject.DAL;
using spr24_team4_finalproject.Models;

namespace spr24_team4_finalproject.Seeding
{
	public class SeedTickets
	{
        public static void SeedAllTickets(AppDbContext db)
        {

            List<Tickets> TickettoAdd = new List<Tickets>();

            Tickets T1 = new Tickets()
            {
                SeatNumber = Seats.Econ3A,
                TicketPrice = 117m,
                DiscountType = DiscountType.SeniorCitizen,
                TicketStatus = TicketStatus.Active,
                MilesEarned = 148,
                ModificationFee = 0,
            };
            T1.Flight = db.Flight.FirstOrDefault(f => f.FlightNumber == 1002);
            T1.Reservation = db.Reservation.FirstOrDefault(r => r.ReservationNumber == 10000);
            T1.Ticketholder = db.Users.FirstOrDefault(u => u.UserName == "cbaker@freserve.co.uk");

            TickettoAdd.Add(T1);

            Tickets T2 = new Tickets()
            {
                SeatNumber = Seats.First1A,
                TicketPrice = 270m,
                DiscountType = DiscountType.General,
                TicketStatus = TicketStatus.Active,
                MilesEarned = 224,
                ModificationFee = 0,
            };
            T2.Flight = db.Flight.FirstOrDefault(f => f.FlightNumber == 1014);
            T2.Reservation = db.Reservation.FirstOrDefault(r => r.ReservationNumber == 10001);
            T2.Ticketholder = db.Users.FirstOrDefault(u => u.UserName == "wchang@gogle.com");

            TickettoAdd.Add(T2);

            Tickets T3 = new Tickets()
            {
                SeatNumber = Seats.First1B,
                TicketPrice = 270m,
                DiscountType = DiscountType.General,
                TicketStatus = TicketStatus.Active,
                MilesEarned = 224,
                ModificationFee = 0,
            };
            T3.Flight = db.Flight.FirstOrDefault(f => f.FlightNumber == 1014);
            T3.Reservation = db.Reservation.FirstOrDefault(r => r.ReservationNumber == 10001);
            T3.Ticketholder = db.Users.FirstOrDefault(u => u.UserName == "limchou@yoho.com");

            TickettoAdd.Add(T3);

            Tickets T4 = new Tickets()
            {
                SeatNumber = Seats.First2A,
                TicketPrice = 270m,
                DiscountType = DiscountType.General,
                TicketStatus = TicketStatus.Active,
                MilesEarned = 224,
                ModificationFee = 0,
            };
            T4.Flight = db.Flight.FirstOrDefault(f => f.FlightNumber == 1014);
            T4.Reservation = db.Reservation.FirstOrDefault(r => r.ReservationNumber == 10001);
            T4.Ticketholder = db.Users.FirstOrDefault(u => u.UserName == "mgarcia@gogle.com");

            TickettoAdd.Add(T4);

            Tickets T5 = new Tickets()
            {
                SeatNumber = Seats.Econ3B,
                TicketPrice = 98m,
                DiscountType = DiscountType.General,
                TicketStatus = TicketStatus.Active,
                MilesEarned = 551,
                ModificationFee = 0,
            };
            T5.Flight = db.Flight.FirstOrDefault(f => f.FlightNumber == 1006);
            T5.Reservation = db.Reservation.FirstOrDefault(r => r.ReservationNumber == 10002);
            T5.Ticketholder = db.Users.FirstOrDefault(u => u.UserName == "chaley@thug.com");

            TickettoAdd.Add(T5);

            foreach (Tickets TickettoAddtoDB in TickettoAdd)
            {

                db.Ticket.Add(TickettoAddtoDB);
                db.SaveChanges();
            }
        }
    }
}

