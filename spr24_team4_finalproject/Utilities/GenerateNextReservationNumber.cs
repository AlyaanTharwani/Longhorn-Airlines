using spr24_team4_finalproject.DAL;
using System;
using System.Linq;


namespace spr24_team4_finalproject.Utilities
{
    public static class GenerateNextReservationNumber
    {
        public static Int32 GetNextReservationNumber(AppDbContext _context)
        {
            //set a constant to designate where the order numbers 
            //should start
            const Int32 START_NUMBER = 10000;

            Int32 intMaxReservationNumber; //the current maximum order number
            Int32 intNextReservationNumber; //the order number for the next class

            if (_context.Reservation.Count() == 0) //there are no orders in the database yet
            {
                intMaxReservationNumber = START_NUMBER; //order numbers start at 10001
            }
            else
            {
                intMaxReservationNumber = _context.Reservation.Max(r => r.ReservationNumber); //this is the highest number in the database right now
            }

            //You added records to the datbase before you realized 
            //that you needed this and now you have numbers less than 100 
            //in the database
            if (intMaxReservationNumber < START_NUMBER)
            {
                intMaxReservationNumber = START_NUMBER;
            }

            //add one to the current max to find the next one
            intNextReservationNumber = intMaxReservationNumber + 1;

            //return the value
            return intNextReservationNumber;
        }

    }
}