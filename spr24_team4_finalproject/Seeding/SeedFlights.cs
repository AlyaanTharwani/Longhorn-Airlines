using spr24_team4_finalproject.Models;
using spr24_team4_finalproject.DAL;


namespace spr24_team4_finalproject.Seeding
{
    public static class SeedFlights
    {
        public static void SeedAllFlights(AppDbContext db)
        {

            List<Flights> FlightstoAdd = new List<Flights>();

            Flights F1 = new Flights()
            {
                FlightIdentifier = 1000,
                FlightNumber = 1000,
                DepartureDateTime = DateTime.Parse("2024-04-15 08:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-04-15 08:55:00"),
                status = Status.Active,
                EconomyPrice = 105m,
                AvailableSeats = 16
            };
            F1.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "DFW");

            FlightstoAdd.Add(F1);

            Flights F2 = new Flights()
            {
                FlightIdentifier = 1001,
                FlightNumber = 1002,
                DepartureDateTime = DateTime.Parse("2024-04-15 11:15:00"),
                ArrivalDateTime = DateTime.Parse("2024-04-15 12:15:00"),
                status = Status.Active,
                EconomyPrice = 130m,
                AvailableSeats = 15
            };
            F2.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "HOU");

            FlightstoAdd.Add(F2);

            Flights F3 = new Flights()
            {
                FlightIdentifier = 1002,
                FlightNumber = 1006,
                DepartureDateTime = DateTime.Parse("2024-04-15 09:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-04-15 10:53:00"),
                status = Status.Active,
                EconomyPrice = 98m,
                AvailableSeats = 15
            };
            F3.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "DFW" && f.City2 == "ELP");

            FlightstoAdd.Add(F3);

            Flights F4 = new Flights()
            {
                FlightIdentifier = 1003,
                FlightNumber = 1000,
                DepartureDateTime = DateTime.Parse("2024-04-16 08:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-04-16 08:55:00"),
                status = Status.Active,
                EconomyPrice = 105m,
                AvailableSeats = 16
            };
            F4.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "DFW");

            FlightstoAdd.Add(F4);

            Flights F5 = new Flights()
            {
                FlightIdentifier = 1004,
                FlightNumber = 1002,
                DepartureDateTime = DateTime.Parse("2024-04-16 11:15:00"),
                ArrivalDateTime = DateTime.Parse("2024-04-16 12:15:00"),
                status = Status.Active,
                EconomyPrice = 130m,
                AvailableSeats = 16
            };
            F5.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "HOU");

            FlightstoAdd.Add(F5);

            Flights F6 = new Flights()
            {
                FlightIdentifier = 1005,
                FlightNumber = 1006,
                DepartureDateTime = DateTime.Parse("2024-04-16 09:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-04-16 10:53:00"),
                status = Status.Active,
                EconomyPrice = 98m,
                AvailableSeats = 16
            };
            F6.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "DFW" && f.City2 == "ELP");

            FlightstoAdd.Add(F6);

            Flights F7 = new Flights()
            {
                FlightIdentifier = 1006,
                FlightNumber = 1000,
                DepartureDateTime = DateTime.Parse("2024-04-17 08:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-04-17 08:55:00"),
                status = Status.Active,
                EconomyPrice = 105m,
                AvailableSeats = 16
            };
            F7.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "DFW");

            FlightstoAdd.Add(F7);

            Flights F8 = new Flights()
            {
                FlightIdentifier = 1007,
                FlightNumber = 1002,
                DepartureDateTime = DateTime.Parse("2024-04-17 11:15:00"),
                ArrivalDateTime = DateTime.Parse("2024-04-17 12:15:00"),
                status = Status.Active,
                EconomyPrice = 130m,
                AvailableSeats = 16
            };
            F8.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "HOU");

            FlightstoAdd.Add(F8);

            Flights F9 = new Flights()
            {
                FlightIdentifier = 1008,
                FlightNumber = 1006,
                DepartureDateTime = DateTime.Parse("2024-04-17 09:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-04-17 10:53:00"),
                status = Status.Active,
                EconomyPrice = 98m,
                AvailableSeats = 16
            };
            F9.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "DFW" && f.City2 == "ELP");

            FlightstoAdd.Add(F9);

            Flights F10 = new Flights()
            {
                FlightIdentifier = 1009,
                FlightNumber = 1000,
                DepartureDateTime = DateTime.Parse("2024-04-18 08:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-04-18 08:55:00"),
                status = Status.Active,
                EconomyPrice = 105m,
                AvailableSeats = 16
            };
            F10.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "DFW");

            FlightstoAdd.Add(F10);

            Flights F11 = new Flights()
            {
                FlightIdentifier = 1010,
                FlightNumber = 1002,
                DepartureDateTime = DateTime.Parse("2024-04-18 11:15:00"),
                ArrivalDateTime = DateTime.Parse("2024-04-18 12:15:00"),
                status = Status.Active,
                EconomyPrice = 130m,
                AvailableSeats = 16
            };
            F11.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "HOU");

            FlightstoAdd.Add(F11);

            Flights F12 = new Flights()
            {
                FlightIdentifier = 1011,
                FlightNumber = 1006,
                DepartureDateTime = DateTime.Parse("2024-04-18 09:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-04-18 10:53:00"),
                status = Status.Active,
                EconomyPrice = 98m,
                AvailableSeats = 16
            };
            F12.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "DFW" && f.City2 == "ELP");

            FlightstoAdd.Add(F12);

            Flights F13 = new Flights()
            {
                FlightIdentifier = 1012,
                FlightNumber = 1000,
                DepartureDateTime = DateTime.Parse("2024-04-19 08:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-04-19 08:55:00"),
                status = Status.Active,
                EconomyPrice = 105m,
                AvailableSeats = 16
            };
            F13.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "DFW");

            FlightstoAdd.Add(F13);

            Flights F14 = new Flights()
            {
                FlightIdentifier = 1013,
                FlightNumber = 1002,
                DepartureDateTime = DateTime.Parse("2024-04-19 11:15:00"),
                ArrivalDateTime = DateTime.Parse("2024-04-19 12:15:00"),
                status = Status.Active,
                EconomyPrice = 130m,
                AvailableSeats = 16
            };
            F14.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "HOU");

            FlightstoAdd.Add(F14);

            Flights F15 = new Flights()
            {
                FlightIdentifier = 1014,
                FlightNumber = 1006,
                DepartureDateTime = DateTime.Parse("2024-04-19 09:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-04-19 10:53:00"),
                status = Status.Active,
                EconomyPrice = 98m,
                AvailableSeats = 16
            };
            F15.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "DFW" && f.City2 == "ELP");

            FlightstoAdd.Add(F15);

            Flights F16 = new Flights()
            {
                FlightIdentifier = 1015,
                FlightNumber = 1002,
                DepartureDateTime = DateTime.Parse("2024-04-20 11:15:00"),
                ArrivalDateTime = DateTime.Parse("2024-04-20 12:15:00"),
                status = Status.Active,
                EconomyPrice = 130m,
                AvailableSeats = 16
            };
            F16.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "HOU");

            FlightstoAdd.Add(F16);

            Flights F17 = new Flights()
            {
                FlightIdentifier = 1016,
                FlightNumber = 1014,
                DepartureDateTime = DateTime.Parse("2024-04-20 10:30:00"),
                ArrivalDateTime = DateTime.Parse("2024-04-20 11:43:00"),
                status = Status.Active,
                EconomyPrice = 225m,
                AvailableSeats = 13
            };
            F17.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "DFW" && f.City2 == "HOU");

            FlightstoAdd.Add(F17);

            Flights F18 = new Flights()
            {
                FlightIdentifier = 1017,
                FlightNumber = 1002,
                DepartureDateTime = DateTime.Parse("2024-04-21 11:15:00"),
                ArrivalDateTime = DateTime.Parse("2024-04-21 12:15:00"),
                status = Status.Active,
                EconomyPrice = 130m,
                AvailableSeats = 16
            };
            F18.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "HOU");

            FlightstoAdd.Add(F18);

            Flights F19 = new Flights()
            {
                FlightIdentifier = 1018,
                FlightNumber = 1000,
                DepartureDateTime = DateTime.Parse("2024-04-22 08:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-04-22 08:55:00"),
                status = Status.Active,
                EconomyPrice = 105m,
                AvailableSeats = 16
            };
            F19.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "DFW");

            FlightstoAdd.Add(F19);

            Flights F20 = new Flights()
            {
                FlightIdentifier = 1019,
                FlightNumber = 1002,
                DepartureDateTime = DateTime.Parse("2024-04-22 11:15:00"),
                ArrivalDateTime = DateTime.Parse("2024-04-22 12:15:00"),
                status = Status.Active,
                EconomyPrice = 130m,
                AvailableSeats = 16
            };
            F20.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "HOU");

            FlightstoAdd.Add(F20);

            Flights F21 = new Flights()
            {
                FlightIdentifier = 1020,
                FlightNumber = 1006,
                DepartureDateTime = DateTime.Parse("2024-04-22 09:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-04-22 10:53:00"),
                status = Status.Active,
                EconomyPrice = 98m,
                AvailableSeats = 16
            };
            F21.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "DFW" && f.City2 == "ELP");

            FlightstoAdd.Add(F21);

            Flights F22 = new Flights()
            {
                FlightIdentifier = 1021,
                FlightNumber = 1000,
                DepartureDateTime = DateTime.Parse("2024-04-23 08:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-04-23 08:55:00"),
                status = Status.Active,
                EconomyPrice = 105m,
                AvailableSeats = 16
            };
            F22.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "DFW");

            FlightstoAdd.Add(F22);

            Flights F23 = new Flights()
            {
                FlightIdentifier = 1022,
                FlightNumber = 1002,
                DepartureDateTime = DateTime.Parse("2024-04-23 11:15:00"),
                ArrivalDateTime = DateTime.Parse("2024-04-23 12:15:00"),
                status = Status.Active,
                EconomyPrice = 130m,
                AvailableSeats = 16
            };
            F23.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "HOU");

            FlightstoAdd.Add(F23);

            Flights F24 = new Flights()
            {
                FlightIdentifier = 1023,
                FlightNumber = 1006,
                DepartureDateTime = DateTime.Parse("2024-04-23 09:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-04-23 10:53:00"),
                status = Status.Active,
                EconomyPrice = 98m,
                AvailableSeats = 16
            };
            F24.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "DFW" && f.City2 == "ELP");

            FlightstoAdd.Add(F24);

            Flights F25 = new Flights()
            {
                FlightIdentifier = 1024,
                FlightNumber = 1000,
                DepartureDateTime = DateTime.Parse("2024-04-24 08:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-04-24 08:55:00"),
                status = Status.Active,
                EconomyPrice = 105m,
                AvailableSeats = 16
            };
            F25.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "DFW");

            FlightstoAdd.Add(F25);

            Flights F26 = new Flights()
            {
                FlightIdentifier = 1025,
                FlightNumber = 1002,
                DepartureDateTime = DateTime.Parse("2024-04-24 11:15:00"),
                ArrivalDateTime = DateTime.Parse("2024-04-24 12:15:00"),
                status = Status.Active,
                EconomyPrice = 130m,
                AvailableSeats = 16
            };
            F26.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "HOU");

            FlightstoAdd.Add(F26);

            Flights F27 = new Flights()
            {
                FlightIdentifier = 1026,
                FlightNumber = 1006,
                DepartureDateTime = DateTime.Parse("2024-04-24 09:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-04-24 10:53:00"),
                status = Status.Active,
                EconomyPrice = 98m,
                AvailableSeats = 16
            };
            F27.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "DFW" && f.City2 == "ELP");

            FlightstoAdd.Add(F27);

            Flights F28 = new Flights()
            {
                FlightIdentifier = 1027,
                FlightNumber = 1000,
                DepartureDateTime = DateTime.Parse("2024-04-25 08:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-04-25 08:55:00"),
                status = Status.Active,
                EconomyPrice = 105m,
                AvailableSeats = 16
            };
            F28.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "DFW");

            FlightstoAdd.Add(F28);

            Flights F29 = new Flights()
            {
                FlightIdentifier = 1028,
                FlightNumber = 1002,
                DepartureDateTime = DateTime.Parse("2024-04-25 11:15:00"),
                ArrivalDateTime = DateTime.Parse("2024-04-25 12:15:00"),
                status = Status.Active,
                EconomyPrice = 130m,
                AvailableSeats = 16
            };
            F29.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "HOU");

            FlightstoAdd.Add(F29);

            Flights F30 = new Flights()
            {
                FlightIdentifier = 1029,
                FlightNumber = 1006,
                DepartureDateTime = DateTime.Parse("2024-04-25 09:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-04-25 10:53:00"),
                status = Status.Active,
                EconomyPrice = 98m,
                AvailableSeats = 16
            };
            F30.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "DFW" && f.City2 == "ELP");

            FlightstoAdd.Add(F30);

            Flights F31 = new Flights()
            {
                FlightIdentifier = 1030,
                FlightNumber = 1000,
                DepartureDateTime = DateTime.Parse("2024-04-26 08:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-04-26 08:55:00"),
                status = Status.Active,
                EconomyPrice = 105m,
                AvailableSeats = 16
            };
            F31.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "DFW");

            FlightstoAdd.Add(F31);

            Flights F32 = new Flights()
            {
                FlightIdentifier = 1031,
                FlightNumber = 1002,
                DepartureDateTime = DateTime.Parse("2024-04-26 11:15:00"),
                ArrivalDateTime = DateTime.Parse("2024-04-26 12:15:00"),
                status = Status.Active,
                EconomyPrice = 130m,
                AvailableSeats = 16
            };
            F32.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "HOU");

            FlightstoAdd.Add(F32);

            Flights F33 = new Flights()
            {
                FlightIdentifier = 1032,
                FlightNumber = 1006,
                DepartureDateTime = DateTime.Parse("2024-04-26 09:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-04-26 10:53:00"),
                status = Status.Active,
                EconomyPrice = 98m,
                AvailableSeats = 16
            };
            F33.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "DFW" && f.City2 == "ELP");

            FlightstoAdd.Add(F33);

            Flights F34 = new Flights()
            {
                FlightIdentifier = 1033,
                FlightNumber = 1002,
                DepartureDateTime = DateTime.Parse("2024-04-27 11:15:00"),
                ArrivalDateTime = DateTime.Parse("2024-04-27 12:15:00"),
                status = Status.Active,
                EconomyPrice = 130m,
                AvailableSeats = 16
            };
            F34.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "HOU");

            FlightstoAdd.Add(F34);

            Flights F35 = new Flights()
            {
                FlightIdentifier = 1034,
                FlightNumber = 1014,
                DepartureDateTime = DateTime.Parse("2024-04-27 10:30:00"),
                ArrivalDateTime = DateTime.Parse("2024-04-27 11:43:00"),
                status = Status.Active,
                EconomyPrice = 225m,
                AvailableSeats = 16
            };
            F35.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "DFW" && f.City2 == "HOU");

            FlightstoAdd.Add(F35);

            Flights F36 = new Flights()
            {
                FlightIdentifier = 1035,
                FlightNumber = 1002,
                DepartureDateTime = DateTime.Parse("2024-04-28 11:15:00"),
                ArrivalDateTime = DateTime.Parse("2024-04-28 12:15:00"),
                status = Status.Active,
                EconomyPrice = 130m,
                AvailableSeats = 16
            };
            F36.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "HOU");

            FlightstoAdd.Add(F36);

            Flights F37 = new Flights()
            {
                FlightIdentifier = 1036,
                FlightNumber = 1000,
                DepartureDateTime = DateTime.Parse("2024-04-29 08:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-04-29 08:55:00"),
                status = Status.Active,
                EconomyPrice = 105m,
                AvailableSeats = 16
            };
            F37.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "DFW");

            FlightstoAdd.Add(F37);

            Flights F38 = new Flights()
            {
                FlightIdentifier = 1037,
                FlightNumber = 1002,
                DepartureDateTime = DateTime.Parse("2024-04-29 11:15:00"),
                ArrivalDateTime = DateTime.Parse("2024-04-29 12:15:00"),
                status = Status.Active,
                EconomyPrice = 130m,
                AvailableSeats = 16
            };
            F38.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "HOU");

            FlightstoAdd.Add(F38);

            Flights F39 = new Flights()
            {
                FlightIdentifier = 1038,
                FlightNumber = 1006,
                DepartureDateTime = DateTime.Parse("2024-04-29 09:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-04-29 10:53:00"),
                status = Status.Active,
                EconomyPrice = 98m,
                AvailableSeats = 16
            };
            F39.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "DFW" && f.City2 == "ELP");

            FlightstoAdd.Add(F39);

            Flights F40 = new Flights()
            {
                FlightIdentifier = 1039,
                FlightNumber = 1000,
                DepartureDateTime = DateTime.Parse("2024-04-30 08:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-04-30 08:55:00"),
                status = Status.Active,
                EconomyPrice = 105m,
                AvailableSeats = 16
            };
            F40.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "DFW");

            FlightstoAdd.Add(F40);

            Flights F41 = new Flights()
            {
                FlightIdentifier = 1040,
                FlightNumber = 1002,
                DepartureDateTime = DateTime.Parse("2024-04-30 11:15:00"),
                ArrivalDateTime = DateTime.Parse("2024-04-30 12:15:00"),
                status = Status.Active,
                EconomyPrice = 130m,
                AvailableSeats = 16
            };
            F41.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "HOU");

            FlightstoAdd.Add(F41);

            Flights F42 = new Flights()
            {
                FlightIdentifier = 1041,
                FlightNumber = 1006,
                DepartureDateTime = DateTime.Parse("2024-04-30 09:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-04-30 10:53:00"),
                status = Status.Active,
                EconomyPrice = 98m,
                AvailableSeats = 16
            };
            F42.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "DFW" && f.City2 == "ELP");

            FlightstoAdd.Add(F42);

            Flights F43 = new Flights()
            {
                FlightIdentifier = 1042,
                FlightNumber = 1000,
                DepartureDateTime = DateTime.Parse("2024-05-01 08:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-01 08:55:00"),
                status = Status.Active,
                EconomyPrice = 105m,
                AvailableSeats = 16
            };
            F43.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "DFW");

            FlightstoAdd.Add(F43);

            Flights F44 = new Flights()
            {
                FlightIdentifier = 1043,
                FlightNumber = 1002,
                DepartureDateTime = DateTime.Parse("2024-05-01 11:15:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-01 12:15:00"),
                status = Status.Active,
                EconomyPrice = 130m,
                AvailableSeats = 16
            };
            F44.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "HOU");

            FlightstoAdd.Add(F44);

            Flights F45 = new Flights()
            {
                FlightIdentifier = 1044,
                FlightNumber = 1006,
                DepartureDateTime = DateTime.Parse("2024-05-01 09:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-01 10:53:00"),
                status = Status.Active,
                EconomyPrice = 98m,
                AvailableSeats = 16
            };
            F45.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "DFW" && f.City2 == "ELP");

            FlightstoAdd.Add(F45);

            Flights F46 = new Flights()
            {
                FlightIdentifier = 1045,
                FlightNumber = 1000,
                DepartureDateTime = DateTime.Parse("2024-05-02 08:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-02 08:55:00"),
                status = Status.Active,
                EconomyPrice = 105m,
                AvailableSeats = 16
            };
            F46.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "DFW");

            FlightstoAdd.Add(F46);

            Flights F47 = new Flights()
            {
                FlightIdentifier = 1046,
                FlightNumber = 1002,
                DepartureDateTime = DateTime.Parse("2024-05-02 11:15:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-02 12:15:00"),
                status = Status.Active,
                EconomyPrice = 130m,
                AvailableSeats = 16
            };
            F47.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "HOU");

            FlightstoAdd.Add(F47);

            Flights F48 = new Flights()
            {
                FlightIdentifier = 1047,
                FlightNumber = 1006,
                DepartureDateTime = DateTime.Parse("2024-05-02 09:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-02 10:53:00"),
                status = Status.Active,
                EconomyPrice = 98m,
                AvailableSeats = 16
            };
            F48.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "DFW" && f.City2 == "ELP");

            FlightstoAdd.Add(F48);

            Flights F49 = new Flights()
            {
                FlightIdentifier = 1048,
                FlightNumber = 1000,
                DepartureDateTime = DateTime.Parse("2024-05-03 08:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-03 08:55:00"),
                status = Status.Active,
                EconomyPrice = 105m,
                AvailableSeats = 16
            };
            F49.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "DFW");

            FlightstoAdd.Add(F49);

            Flights F50 = new Flights()
            {
                FlightIdentifier = 1049,
                FlightNumber = 1002,
                DepartureDateTime = DateTime.Parse("2024-05-03 11:15:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-03 12:15:00"),
                status = Status.Active,
                EconomyPrice = 130m,
                AvailableSeats = 16
            };
            F50.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "HOU");

            FlightstoAdd.Add(F50);

            Flights F51 = new Flights()
            {
                FlightIdentifier = 1050,
                FlightNumber = 1006,
                DepartureDateTime = DateTime.Parse("2024-05-03 09:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-03 10:53:00"),
                status = Status.Active,
                EconomyPrice = 98m,
                AvailableSeats = 16
            };
            F51.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "DFW" && f.City2 == "ELP");

            FlightstoAdd.Add(F51);

            Flights F52 = new Flights()
            {
                FlightIdentifier = 1051,
                FlightNumber = 1002,
                DepartureDateTime = DateTime.Parse("2024-05-04 11:15:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-04 12:15:00"),
                status = Status.Active,
                EconomyPrice = 130m,
                AvailableSeats = 16
            };
            F52.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "HOU");

            FlightstoAdd.Add(F52);

            Flights F53 = new Flights()
            {
                FlightIdentifier = 1052,
                FlightNumber = 1014,
                DepartureDateTime = DateTime.Parse("2024-05-04 10:30:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-04 11:43:00"),
                status = Status.Active,
                EconomyPrice = 225m,
                AvailableSeats = 16
            };
            F53.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "DFW" && f.City2 == "HOU");

            FlightstoAdd.Add(F53);

            Flights F54 = new Flights()
            {
                FlightIdentifier = 1053,
                FlightNumber = 1002,
                DepartureDateTime = DateTime.Parse("2024-05-05 11:15:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-05 12:15:00"),
                status = Status.Active,
                EconomyPrice = 130m,
                AvailableSeats = 16
            };
            F54.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "HOU");

            FlightstoAdd.Add(F54);

            Flights F55 = new Flights()
            {
                FlightIdentifier = 1054,
                FlightNumber = 1000,
                DepartureDateTime = DateTime.Parse("2024-05-06 08:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-06 08:55:00"),
                status = Status.Active,
                EconomyPrice = 105m,
                AvailableSeats = 16
            };
            F55.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "DFW");

            FlightstoAdd.Add(F55);

            Flights F56 = new Flights()
            {
                FlightIdentifier = 1055,
                FlightNumber = 1002,
                DepartureDateTime = DateTime.Parse("2024-05-06 11:15:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-06 12:15:00"),
                status = Status.Active,
                EconomyPrice = 130m,
                AvailableSeats = 16
            };
            F56.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "HOU");

            FlightstoAdd.Add(F56);

            Flights F57 = new Flights()
            {
                FlightIdentifier = 1056,
                FlightNumber = 1006,
                DepartureDateTime = DateTime.Parse("2024-05-06 09:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-06 10:53:00"),
                status = Status.Active,
                EconomyPrice = 98m,
                AvailableSeats = 16
            };
            F57.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "DFW" && f.City2 == "ELP");

            FlightstoAdd.Add(F57);

            Flights F58 = new Flights()
            {
                FlightIdentifier = 1057,
                FlightNumber = 1000,
                DepartureDateTime = DateTime.Parse("2024-05-07 08:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-07 08:55:00"),
                status = Status.Active,
                EconomyPrice = 105m,
                AvailableSeats = 16
            };
            F58.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "DFW");

            FlightstoAdd.Add(F58);

            Flights F59 = new Flights()
            {
                FlightIdentifier = 1058,
                FlightNumber = 1002,
                DepartureDateTime = DateTime.Parse("2024-05-07 11:15:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-07 12:15:00"),
                status = Status.Active,
                EconomyPrice = 130m,
                AvailableSeats = 16
            };
            F59.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "HOU");

            FlightstoAdd.Add(F59);

            Flights F60 = new Flights()
            {
                FlightIdentifier = 1059,
                FlightNumber = 1006,
                DepartureDateTime = DateTime.Parse("2024-05-07 09:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-07 10:53:00"),
                status = Status.Active,
                EconomyPrice = 98m,
                AvailableSeats = 16
            };
            F60.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "DFW" && f.City2 == "ELP");

            FlightstoAdd.Add(F60);

            Flights F61 = new Flights()
            {
                FlightIdentifier = 1060,
                FlightNumber = 1000,
                DepartureDateTime = DateTime.Parse("2024-05-08 08:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-08 08:55:00"),
                status = Status.Active,
                EconomyPrice = 105m,
                AvailableSeats = 16
            };
            F61.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "DFW");

            FlightstoAdd.Add(F61);

            Flights F62 = new Flights()
            {
                FlightIdentifier = 1061,
                FlightNumber = 1002,
                DepartureDateTime = DateTime.Parse("2024-05-08 11:15:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-08 12:15:00"),
                status = Status.Active,
                EconomyPrice = 130m,
                AvailableSeats = 16
            };
            F62.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "HOU");

            FlightstoAdd.Add(F62);

            Flights F63 = new Flights()
            {
                FlightIdentifier = 1062,
                FlightNumber = 1006,
                DepartureDateTime = DateTime.Parse("2024-05-08 09:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-08 10:53:00"),
                status = Status.Active,
                EconomyPrice = 98m,
                AvailableSeats = 16
            };
            F63.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "DFW" && f.City2 == "ELP");

            FlightstoAdd.Add(F63);

            Flights F64 = new Flights()
            {
                FlightIdentifier = 1063,
                FlightNumber = 1000,
                DepartureDateTime = DateTime.Parse("2024-05-09 08:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-09 08:55:00"),
                status = Status.Active,
                EconomyPrice = 105m,
                AvailableSeats = 16
            };
            F64.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "DFW");

            FlightstoAdd.Add(F64);

            Flights F65 = new Flights()
            {
                FlightIdentifier = 1064,
                FlightNumber = 1002,
                DepartureDateTime = DateTime.Parse("2024-05-09 11:15:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-09 12:15:00"),
                status = Status.Active,
                EconomyPrice = 130m,
                AvailableSeats = 16
            };
            F65.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "HOU");

            FlightstoAdd.Add(F65);

            Flights F66 = new Flights()
            {
                FlightIdentifier = 1065,
                FlightNumber = 1006,
                DepartureDateTime = DateTime.Parse("2024-05-09 09:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-09 10:53:00"),
                status = Status.Active,
                EconomyPrice = 98m,
                AvailableSeats = 16
            };
            F66.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "DFW" && f.City2 == "ELP");

            FlightstoAdd.Add(F66);

            Flights F67 = new Flights()
            {
                FlightIdentifier = 1066,
                FlightNumber = 1000,
                DepartureDateTime = DateTime.Parse("2024-05-10 08:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-10 08:55:00"),
                status = Status.Active,
                EconomyPrice = 105m,
                AvailableSeats = 16
            };
            F67.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "DFW");

            FlightstoAdd.Add(F67);

            Flights F68 = new Flights()
            {
                FlightIdentifier = 1067,
                FlightNumber = 1002,
                DepartureDateTime = DateTime.Parse("2024-05-10 11:15:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-10 12:15:00"),
                status = Status.Active,
                EconomyPrice = 130m,
                AvailableSeats = 16
            };
            F68.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "HOU");

            FlightstoAdd.Add(F68);

            Flights F69 = new Flights()
            {
                FlightIdentifier = 1068,
                FlightNumber = 1006,
                DepartureDateTime = DateTime.Parse("2024-05-10 09:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-10 10:53:00"),
                status = Status.Active,
                EconomyPrice = 98m,
                AvailableSeats = 16
            };
            F69.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "DFW" && f.City2 == "ELP");

            FlightstoAdd.Add(F69);

            Flights F70 = new Flights()
            {
                FlightIdentifier = 1069,
                FlightNumber = 1002,
                DepartureDateTime = DateTime.Parse("2024-05-11 11:15:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-11 12:15:00"),
                status = Status.Active,
                EconomyPrice = 130m,
                AvailableSeats = 16
            };
            F70.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "HOU");

            FlightstoAdd.Add(F70);

            Flights F71 = new Flights()
            {
                FlightIdentifier = 1070,
                FlightNumber = 1014,
                DepartureDateTime = DateTime.Parse("2024-05-11 10:30:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-11 11:43:00"),
                status = Status.Active,
                EconomyPrice = 225m,
                AvailableSeats = 16
            };
            F71.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "DFW" && f.City2 == "HOU");

            FlightstoAdd.Add(F71);

            Flights F72 = new Flights()
            {
                FlightIdentifier = 1071,
                FlightNumber = 1002,
                DepartureDateTime = DateTime.Parse("2024-05-12 11:15:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-12 12:15:00"),
                status = Status.Active,
                EconomyPrice = 130m,
                AvailableSeats = 16
            };
            F72.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "HOU");

            FlightstoAdd.Add(F72);

            Flights F73 = new Flights()
            {
                FlightIdentifier = 1072,
                FlightNumber = 1000,
                DepartureDateTime = DateTime.Parse("2024-05-13 08:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-13 08:55:00"),
                status = Status.Active,
                EconomyPrice = 105m,
                AvailableSeats = 16
            };
            F73.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "DFW");

            FlightstoAdd.Add(F73);

            Flights F74 = new Flights()
            {
                FlightIdentifier = 1073,
                FlightNumber = 1002,
                DepartureDateTime = DateTime.Parse("2024-05-13 11:15:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-13 12:15:00"),
                status = Status.Active,
                EconomyPrice = 130m,
                AvailableSeats = 16
            };
            F74.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "HOU");

            FlightstoAdd.Add(F74);

            Flights F75 = new Flights()
            {
                FlightIdentifier = 1074,
                FlightNumber = 1006,
                DepartureDateTime = DateTime.Parse("2024-05-13 09:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-13 10:53:00"),
                status = Status.Active,
                EconomyPrice = 98m,
                AvailableSeats = 16
            };
            F75.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "DFW" && f.City2 == "ELP");

            FlightstoAdd.Add(F75);

            Flights F76 = new Flights()
            {
                FlightIdentifier = 1075,
                FlightNumber = 1000,
                DepartureDateTime = DateTime.Parse("2024-05-14 08:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-14 08:55:00"),
                status = Status.Active,
                EconomyPrice = 105m,
                AvailableSeats = 16
            };
            F76.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "DFW");

            FlightstoAdd.Add(F76);

            Flights F77 = new Flights()
            {
                FlightIdentifier = 1076,
                FlightNumber = 1002,
                DepartureDateTime = DateTime.Parse("2024-05-14 11:15:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-14 12:15:00"),
                status = Status.Active,
                EconomyPrice = 130m,
                AvailableSeats = 16
            };
            F77.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "HOU");

            FlightstoAdd.Add(F77);

            Flights F78 = new Flights()
            {
                FlightIdentifier = 1077,
                FlightNumber = 1006,
                DepartureDateTime = DateTime.Parse("2024-05-14 09:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-14 10:53:00"),
                status = Status.Active,
                EconomyPrice = 98m,
                AvailableSeats = 16
            };
            F78.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "DFW" && f.City2 == "ELP");

            FlightstoAdd.Add(F78);

            Flights F79 = new Flights()
            {
                FlightIdentifier = 1078,
                FlightNumber = 1000,
                DepartureDateTime = DateTime.Parse("2024-05-15 08:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-15 08:55:00"),
                status = Status.Active,
                EconomyPrice = 105m,
                AvailableSeats = 16
            };
            F79.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "DFW");

            FlightstoAdd.Add(F79);

            Flights F80 = new Flights()
            {
                FlightIdentifier = 1079,
                FlightNumber = 1002,
                DepartureDateTime = DateTime.Parse("2024-05-15 11:15:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-15 12:15:00"),
                status = Status.Active,
                EconomyPrice = 130m,
                AvailableSeats = 16
            };
            F80.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "HOU");

            FlightstoAdd.Add(F80);

            Flights F81 = new Flights()
            {
                FlightIdentifier = 1080,
                FlightNumber = 1006,
                DepartureDateTime = DateTime.Parse("2024-05-15 09:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-15 10:53:00"),
                status = Status.Active,
                EconomyPrice = 98m,
                AvailableSeats = 16
            };
            F81.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "DFW" && f.City2 == "ELP");

            FlightstoAdd.Add(F81);

            Flights F82 = new Flights()
            {
                FlightIdentifier = 1081,
                FlightNumber = 1000,
                DepartureDateTime = DateTime.Parse("2024-05-16 08:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-16 08:55:00"),
                status = Status.Active,
                EconomyPrice = 105m,
                AvailableSeats = 16
            };
            F82.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "DFW");

            FlightstoAdd.Add(F82);

            Flights F83 = new Flights()
            {
                FlightIdentifier = 1082,
                FlightNumber = 1002,
                DepartureDateTime = DateTime.Parse("2024-05-16 11:15:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-16 12:15:00"),
                status = Status.Active,
                EconomyPrice = 130m,
                AvailableSeats = 16
            };
            F83.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "HOU");

            FlightstoAdd.Add(F83);

            Flights F84 = new Flights()
            {
                FlightIdentifier = 1083,
                FlightNumber = 1006,
                DepartureDateTime = DateTime.Parse("2024-05-16 09:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-16 10:53:00"),
                status = Status.Active,
                EconomyPrice = 98m,
                AvailableSeats = 16
            };
            F84.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "DFW" && f.City2 == "ELP");

            FlightstoAdd.Add(F84);

            Flights F85 = new Flights()
            {
                FlightIdentifier = 1084,
                FlightNumber = 1000,
                DepartureDateTime = DateTime.Parse("2024-05-17 08:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-17 08:55:00"),
                status = Status.Active,
                EconomyPrice = 105m,
                AvailableSeats = 16
            };
            F85.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "DFW");

            FlightstoAdd.Add(F85);

            Flights F86 = new Flights()
            {
                FlightIdentifier = 1085,
                FlightNumber = 1002,
                DepartureDateTime = DateTime.Parse("2024-05-17 11:15:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-17 12:15:00"),
                status = Status.Active,
                EconomyPrice = 130m,
                AvailableSeats = 16
            };
            F86.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "HOU");

            FlightstoAdd.Add(F86);

            Flights F87 = new Flights()
            {
                FlightIdentifier = 1086,
                FlightNumber = 1006,
                DepartureDateTime = DateTime.Parse("2024-05-17 09:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-17 10:53:00"),
                status = Status.Active,
                EconomyPrice = 98m,
                AvailableSeats = 16
            };
            F87.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "DFW" && f.City2 == "ELP");

            FlightstoAdd.Add(F87);

            Flights F88 = new Flights()
            {
                FlightIdentifier = 1087,
                FlightNumber = 1002,
                DepartureDateTime = DateTime.Parse("2024-05-18 11:15:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-18 12:15:00"),
                status = Status.Active,
                EconomyPrice = 130m,
                AvailableSeats = 16
            };
            F88.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "HOU");

            FlightstoAdd.Add(F88);

            Flights F89 = new Flights()
            {
                FlightIdentifier = 1088,
                FlightNumber = 1014,
                DepartureDateTime = DateTime.Parse("2024-05-18 10:30:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-18 11:43:00"),
                status = Status.Active,
                EconomyPrice = 225m,
                AvailableSeats = 16
            };
            F89.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "DFW" && f.City2 == "HOU");

            FlightstoAdd.Add(F89);

            Flights F90 = new Flights()
            {
                FlightIdentifier = 1089,
                FlightNumber = 1002,
                DepartureDateTime = DateTime.Parse("2024-05-19 11:15:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-19 12:15:00"),
                status = Status.Active,
                EconomyPrice = 130m,
                AvailableSeats = 16
            };
            F90.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "HOU");

            FlightstoAdd.Add(F90);

            Flights F91 = new Flights()
            {
                FlightIdentifier = 1090,
                FlightNumber = 1000,
                DepartureDateTime = DateTime.Parse("2024-05-20 08:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-20 08:55:00"),
                status = Status.Active,
                EconomyPrice = 105m,
                AvailableSeats = 16
            };
            F91.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "DFW");

            FlightstoAdd.Add(F91);

            Flights F92 = new Flights()
            {
                FlightIdentifier = 1091,
                FlightNumber = 1002,
                DepartureDateTime = DateTime.Parse("2024-05-20 11:15:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-20 12:15:00"),
                status = Status.Active,
                EconomyPrice = 130m,
                AvailableSeats = 16
            };
            F92.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "HOU");

            FlightstoAdd.Add(F92);

            Flights F93 = new Flights()
            {
                FlightIdentifier = 1092,
                FlightNumber = 1006,
                DepartureDateTime = DateTime.Parse("2024-05-20 09:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-20 10:53:00"),
                status = Status.Active,
                EconomyPrice = 98m,
                AvailableSeats = 16
            };
            F93.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "DFW" && f.City2 == "ELP");

            FlightstoAdd.Add(F93);

            Flights F94 = new Flights()
            {
                FlightIdentifier = 1093,
                FlightNumber = 1000,
                DepartureDateTime = DateTime.Parse("2024-05-21 08:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-21 08:55:00"),
                status = Status.Active,
                EconomyPrice = 105m,
                AvailableSeats = 16
            };
            F94.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "DFW");

            FlightstoAdd.Add(F94);

            Flights F95 = new Flights()
            {
                FlightIdentifier = 1094,
                FlightNumber = 1002,
                DepartureDateTime = DateTime.Parse("2024-05-21 11:15:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-21 12:15:00"),
                status = Status.Active,
                EconomyPrice = 130m,
                AvailableSeats = 16
            };
            F95.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "HOU");

            FlightstoAdd.Add(F95);

            Flights F96 = new Flights()
            {
                FlightIdentifier = 1095,
                FlightNumber = 1006,
                DepartureDateTime = DateTime.Parse("2024-05-21 09:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-21 10:53:00"),
                status = Status.Active,
                EconomyPrice = 98m,
                AvailableSeats = 16
            };
            F96.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "DFW" && f.City2 == "ELP");

            FlightstoAdd.Add(F96);

            Flights F97 = new Flights()
            {
                FlightIdentifier = 1096,
                FlightNumber = 1000,
                DepartureDateTime = DateTime.Parse("2024-05-22 08:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-22 08:55:00"),
                status = Status.Active,
                EconomyPrice = 105m,
                AvailableSeats = 16
            };
            F97.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "DFW");

            FlightstoAdd.Add(F97);

            Flights F98 = new Flights()
            {
                FlightIdentifier = 1097,
                FlightNumber = 1002,
                DepartureDateTime = DateTime.Parse("2024-05-22 11:15:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-22 12:15:00"),
                status = Status.Active,
                EconomyPrice = 130m,
                AvailableSeats = 16
            };
            F98.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "HOU");

            FlightstoAdd.Add(F98);

            Flights F99 = new Flights()
            {
                FlightIdentifier = 1098,
                FlightNumber = 1006,
                DepartureDateTime = DateTime.Parse("2024-05-22 09:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-22 10:53:00"),
                status = Status.Active,
                EconomyPrice = 98m,
                AvailableSeats = 16
            };
            F99.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "DFW" && f.City2 == "ELP");

            FlightstoAdd.Add(F99);

            Flights F100 = new Flights()
            {
                FlightIdentifier = 1099,
                FlightNumber = 1000,
                DepartureDateTime = DateTime.Parse("2024-05-23 08:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-23 08:55:00"),
                status = Status.Active,
                EconomyPrice = 105m,
                AvailableSeats = 16
            };
            F100.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "DFW");

            FlightstoAdd.Add(F100);

            Flights F101 = new Flights()
            {
                FlightIdentifier = 1100,
                FlightNumber = 1002,
                DepartureDateTime = DateTime.Parse("2024-05-23 11:15:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-23 12:15:00"),
                status = Status.Active,
                EconomyPrice = 130m,
                AvailableSeats = 16
            };
            F101.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "HOU");

            FlightstoAdd.Add(F101);

            Flights F102 = new Flights()
            {
                FlightIdentifier = 1101,
                FlightNumber = 1006,
                DepartureDateTime = DateTime.Parse("2024-05-23 09:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-23 10:53:00"),
                status = Status.Active,
                EconomyPrice = 98m,
                AvailableSeats = 16
            };
            F102.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "DFW" && f.City2 == "ELP");

            FlightstoAdd.Add(F102);

            Flights F103 = new Flights()
            {
                FlightIdentifier = 1102,
                FlightNumber = 1000,
                DepartureDateTime = DateTime.Parse("2024-05-24 08:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-24 08:55:00"),
                status = Status.Active,
                EconomyPrice = 105m,
                AvailableSeats = 16
            };
            F103.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "DFW");

            FlightstoAdd.Add(F103);

            Flights F104 = new Flights()
            {
                FlightIdentifier = 1103,
                FlightNumber = 1002,
                DepartureDateTime = DateTime.Parse("2024-05-24 11:15:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-24 12:15:00"),
                status = Status.Active,
                EconomyPrice = 130m,
                AvailableSeats = 16
            };
            F104.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "HOU");

            FlightstoAdd.Add(F104);

            Flights F105 = new Flights()
            {
                FlightIdentifier = 1104,
                FlightNumber = 1006,
                DepartureDateTime = DateTime.Parse("2024-05-24 09:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-24 10:53:00"),
                status = Status.Active,
                EconomyPrice = 98m,
                AvailableSeats = 16
            };
            F105.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "DFW" && f.City2 == "ELP");

            FlightstoAdd.Add(F105);

            Flights F106 = new Flights()
            {
                FlightIdentifier = 1105,
                FlightNumber = 1002,
                DepartureDateTime = DateTime.Parse("2024-05-25 11:15:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-25 12:15:00"),
                status = Status.Active,
                EconomyPrice = 130m,
                AvailableSeats = 16
            };
            F106.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "HOU");

            FlightstoAdd.Add(F106);

            Flights F107 = new Flights()
            {
                FlightIdentifier = 1106,
                FlightNumber = 1014,
                DepartureDateTime = DateTime.Parse("2024-05-25 10:30:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-25 11:43:00"),
                status = Status.Active,
                EconomyPrice = 225m,
                AvailableSeats = 16
            };
            F107.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "DFW" && f.City2 == "HOU");

            FlightstoAdd.Add(F107);

            Flights F108 = new Flights()
            {
                FlightIdentifier = 1107,
                FlightNumber = 1002,
                DepartureDateTime = DateTime.Parse("2024-05-26 11:15:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-26 12:15:00"),
                status = Status.Active,
                EconomyPrice = 130m,
                AvailableSeats = 16
            };
            F108.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "HOU");

            FlightstoAdd.Add(F108);

            Flights F109 = new Flights()
            {
                FlightIdentifier = 1108,
                FlightNumber = 1000,
                DepartureDateTime = DateTime.Parse("2024-05-27 08:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-27 08:55:00"),
                status = Status.Active,
                EconomyPrice = 105m,
                AvailableSeats = 16
            };
            F109.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "DFW");

            FlightstoAdd.Add(F109);

            Flights F110 = new Flights()
            {
                FlightIdentifier = 1109,
                FlightNumber = 1002,
                DepartureDateTime = DateTime.Parse("2024-05-27 11:15:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-27 12:15:00"),
                status = Status.Active,
                EconomyPrice = 130m,
                AvailableSeats = 16
            };
            F110.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "HOU");

            FlightstoAdd.Add(F110);

            Flights F111 = new Flights()
            {
                FlightIdentifier = 1110,
                FlightNumber = 1006,
                DepartureDateTime = DateTime.Parse("2024-05-27 09:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-27 10:53:00"),
                status = Status.Active,
                EconomyPrice = 98m,
                AvailableSeats = 16
            };
            F111.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "DFW" && f.City2 == "ELP");

            FlightstoAdd.Add(F111);

            Flights F112 = new Flights()
            {
                FlightIdentifier = 1111,
                FlightNumber = 1000,
                DepartureDateTime = DateTime.Parse("2024-05-28 08:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-28 08:55:00"),
                status = Status.Active,
                EconomyPrice = 105m,
                AvailableSeats = 16
            };
            F112.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "DFW");

            FlightstoAdd.Add(F112);

            Flights F113 = new Flights()
            {
                FlightIdentifier = 1112,
                FlightNumber = 1002,
                DepartureDateTime = DateTime.Parse("2024-05-28 11:15:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-28 12:15:00"),
                status = Status.Active,
                EconomyPrice = 130m,
                AvailableSeats = 16
            };
            F113.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "HOU");

            FlightstoAdd.Add(F113);

            Flights F114 = new Flights()
            {
                FlightIdentifier = 1113,
                FlightNumber = 1006,
                DepartureDateTime = DateTime.Parse("2024-05-28 09:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-28 10:53:00"),
                status = Status.Active,
                EconomyPrice = 98m,
                AvailableSeats = 16
            };
            F114.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "DFW" && f.City2 == "ELP");

            FlightstoAdd.Add(F114);

            Flights F115 = new Flights()
            {
                FlightIdentifier = 1114,
                FlightNumber = 1000,
                DepartureDateTime = DateTime.Parse("2024-05-29 08:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-29 08:55:00"),
                status = Status.Active,
                EconomyPrice = 105m,
                AvailableSeats = 16
            };
            F115.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "DFW");

            FlightstoAdd.Add(F115);

            Flights F116 = new Flights()
            {
                FlightIdentifier = 1115,
                FlightNumber = 1002,
                DepartureDateTime = DateTime.Parse("2024-05-29 11:15:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-29 12:15:00"),
                status = Status.Active,
                EconomyPrice = 130m,
                AvailableSeats = 16
            };
            F116.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "HOU");

            FlightstoAdd.Add(F116);

            Flights F117 = new Flights()
            {
                FlightIdentifier = 1116,
                FlightNumber = 1006,
                DepartureDateTime = DateTime.Parse("2024-05-29 09:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-29 10:53:00"),
                status = Status.Active,
                EconomyPrice = 98m,
                AvailableSeats = 16
            };
            F117.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "DFW" && f.City2 == "ELP");

            FlightstoAdd.Add(F117);

            Flights F118 = new Flights()
            {
                FlightIdentifier = 1117,
                FlightNumber = 1000,
                DepartureDateTime = DateTime.Parse("2024-05-30 08:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-30 08:55:00"),
                status = Status.Active,
                EconomyPrice = 105m,
                AvailableSeats = 16
            };
            F118.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "DFW");

            FlightstoAdd.Add(F118);

            Flights F119 = new Flights()
            {
                FlightIdentifier = 1118,
                FlightNumber = 1002,
                DepartureDateTime = DateTime.Parse("2024-05-30 11:15:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-30 12:15:00"),
                status = Status.Active,
                EconomyPrice = 130m,
                AvailableSeats = 16
            };
            F119.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "AUS" && f.City2 == "HOU");

            FlightstoAdd.Add(F119);

            Flights F120 = new Flights()
            {
                FlightIdentifier = 1119,
                FlightNumber = 1006,
                DepartureDateTime = DateTime.Parse("2024-05-30 09:00:00"),
                ArrivalDateTime = DateTime.Parse("2024-05-30 10:53:00"),
                status = Status.Active,
                EconomyPrice = 98m,
                AvailableSeats = 16
            };
            F120.FlightRoute = db.FlightRoute.FirstOrDefault(f => f.City1 == "DFW" && f.City2 == "ELP");

            FlightstoAdd.Add(F120);

            foreach (Flights FlighttoAdd in FlightstoAdd)
            {

                db.Flight.Add(FlighttoAdd);
                db.SaveChanges();
            }

        }
    }
}