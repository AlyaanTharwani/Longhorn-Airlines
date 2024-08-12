using spr24_team4_finalproject.Models;
using spr24_team4_finalproject.DAL;

namespace spr24_team4_finalproject.Seeding
{
    public static class SeedFlightPaths
    {
        public static void SeedAllFlightPaths(AppDbContext db)
        {

            List<FlightRoutes> FlightRoutes = new List<FlightRoutes>();

            FlightRoutes F1 = new FlightRoutes()
            { 
                City1 = "AUS",
                City2 = "DFW",
                Duration = TimeSpan.FromMinutes(55),
                Distance = 190
            };
            FlightRoutes.Add(F1);

            FlightRoutes F2 = new FlightRoutes()
            {
                City1 = "AUS",
                City2 = "HOU",
                Duration = TimeSpan.FromHours(1),
                Distance = 148
            };
            FlightRoutes.Add(F2);

            FlightRoutes F3 = new FlightRoutes()
            {
                City1 = "AUS",
                City2 = "ELP",
                Duration = new TimeSpan(0, 1, 40, 0),
                Distance = 527
            };
            FlightRoutes.Add(F3);

            FlightRoutes F4 = new FlightRoutes()
            {
                City1 = "DFW",
                City2 = "HOU",
                Duration = new TimeSpan(0, 1, 13, 0),
                Distance = 224
            };
            FlightRoutes.Add(F4);

            FlightRoutes F5 = new FlightRoutes()
            {
                City1 = "DFW",
                City2 = "ELP",
                Duration = new TimeSpan(0, 1, 53, 0),
                Distance = 551
            };
            FlightRoutes.Add(F5);

            FlightRoutes F6 = new FlightRoutes()
            {
                City1 = "HOU",
                City2 = "ELP",
                Duration = new TimeSpan(0, 2, 9, 0),
                Distance = 667
            };
            FlightRoutes.Add(F6);

            FlightRoutes F7 = new FlightRoutes()
            {
                City1 = "DFW",
                City2 = "AUS",
                Duration = TimeSpan.FromMinutes(55),
                Distance = 190
            };
            FlightRoutes.Add(F7);

            FlightRoutes F8 = new FlightRoutes()
            {
                City1 = "HOU",
                City2 = "AUS",
                Duration = TimeSpan.FromHours(1),
                Distance = 148
            };
            FlightRoutes.Add(F8);

            FlightRoutes F9 = new FlightRoutes()
            {
                City1 = "ELP",
                City2 = "AUS",
                Duration = new TimeSpan(0, 1, 40, 0),
                Distance = 527
            };
            FlightRoutes.Add(F9);

            FlightRoutes F10 = new FlightRoutes()
            {
                City1 = "HOU",
                City2 = "DFW",
                Duration = new TimeSpan(0, 1, 13, 0),
                Distance = 224
            };
            FlightRoutes.Add(F10);

            FlightRoutes F11 = new FlightRoutes()
            {
                City1 = "ELP",
                City2 = "DFW",
                Duration = new TimeSpan(0, 1, 53, 0),
                Distance = 551
            };
            FlightRoutes.Add(F11);

            FlightRoutes F12 = new FlightRoutes()
            {
                City1 = "ELP",
                City2 = "HOU",
                Duration = new TimeSpan(0, 2, 9, 0),
                Distance = 667
            };
            FlightRoutes.Add(F12);

            foreach (FlightRoutes PathtoAdd in FlightRoutes)
                {

                    db.FlightRoute.Add(PathtoAdd);
                    db.SaveChanges();
                }

        }
    }
}