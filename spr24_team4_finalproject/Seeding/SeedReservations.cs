using System;
using spr24_team4_finalproject.DAL;
using spr24_team4_finalproject.Models;

namespace spr24_team4_finalproject.Seeding
{
	public class SeedReservations
	{
        public static void SeedAllRez(AppDbContext db)
        {

            List<Reservations> ReztoAdd = new List<Reservations>();

            Reservations R1 = new Reservations()
            {
                ReservationNumber = 10000,
                PaymentType = Payment.Dollars,
                MilesDeduction = 0,
                ResStatus = ResStatus.Active
            };
            R1.ReservationMaker = db.Users.FirstOrDefault(u => u.UserName == "cbaker@freserve.co.uk");
            ReztoAdd.Add(R1);

            Reservations R2 = new Reservations()
            {
                ReservationNumber = 10001,
                PaymentType = Payment.Dollars,
                MilesDeduction = 0,
                ResStatus = ResStatus.Active
            };
            R2.ReservationMaker = db.Users.FirstOrDefault(u => u.UserName == "wchang@gogle.com");
            ReztoAdd.Add(R2);

            Reservations R3 = new Reservations()
            {
                ReservationNumber = 10002,
                PaymentType = Payment.Dollars,
                MilesDeduction = 0,
                ResStatus = ResStatus.Active
            };
            R3.ReservationMaker = db.Users.FirstOrDefault(u => u.UserName == "mgarcia@gogle.com");
            ReztoAdd.Add(R3);

            foreach (Reservations Rez in ReztoAdd)
            {

                db.Reservation.Add(Rez);
                db.SaveChanges();
            }
        }
	}
}

