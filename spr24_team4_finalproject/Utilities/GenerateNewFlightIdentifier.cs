using System;
using spr24_team4_finalproject.DAL;

namespace spr24_team4_finalproject.Utilities
{
	public class GenerateNewFlightIdentifier
	{
        public static Int32 GetNextFlightIdentifier(AppDbContext _context)
        {
            //set a constant to designate where the registration numbers 
            //should start
            const Int32 START_NUMBER = 1000;

            Int32 intMaxFlightIdentifier; //the current maximum course number
            Int32 intNextFlightIdentifier; //the course number for the next class

            if (_context.Flight.Count() == 0) //there are no Orders in the database yet
            {
                intMaxFlightIdentifier = START_NUMBER; //Order numbers start at 10001
            }
            else
            {
                intMaxFlightIdentifier = _context.Flight.Max(c => c.FlightIdentifier); //this is the highest number in the database right now
            }

            //You added records to the datbase before you realized 
            //that you needed this and now you have numbers less than 100 
            //in the database
            if (intMaxFlightIdentifier < START_NUMBER)
            {
                intMaxFlightIdentifier = START_NUMBER;
            }

            //add one to the current max to find the next one
            intNextFlightIdentifier = intMaxFlightIdentifier + 1;

            //return the value
            return intNextFlightIdentifier;
        }
    }
}

