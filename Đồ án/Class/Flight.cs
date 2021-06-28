using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đồ_án
{
    class Flight
    {
        private int ID_Flight;
        private DateTime De_Time;
        private DateTime Ar_Time;
        private string De_Airport;
        private string Ar_Airport;
        private int Empty_Seat;
        private int Booked_Seat;
        public int ID_FLIGHT
        {
            get
            {
                return ID_Flight;
            }
            set
            {
                ID_Flight = value;
            }
        }
        public DateTime DE_TIME
        {
            get
            {
                return De_Time;
            }
            set
            {
                De_Time = value;
            }
        }
        public DateTime AR_TIME
        {
            get
            {
                return Ar_Time;
            }
            set
            {
                Ar_Time = value;
            }
        }
        public string DE_AIRPORT
        {
            get
            {
                return De_Airport;
            }
            set
            {
                De_Airport = value;
            }
        }
        public string AR_AIRPORT
        {
            get
            {
                return Ar_Airport;
            }
            set
            {
                Ar_Airport = value;
            }
        }
        public  int EMPTY_SEAT
        {
            get
            {
                return Empty_Seat;
            }
            set
            {
                Empty_Seat = value;
            }
        }
        public int BOOKED_SEAT
        {
            get
            {
                return Booked_Seat;
            }
            set
            {
                Booked_Seat = value;
            }
        }

    }
}
