using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đồ_án.Class
{
    class Ticket_Flight
    {
        // Fields ticket
        private int ID_Ticket;
        private decimal Price_Ticket;
        private DateTime DateTime_Ticket;
        private string Seat_Ticket;
        private string Class_Ticket;
        private int ID_Flight; // foreign key
        // Feilds flight
        private DateTime De_Time;
        private DateTime Ar_Time;
        private string De_Airport;
        private string Ar_Airport;
        private int Empty__Seat;
        private int Booked_Seat;

        // Properties
        public int ID_TICKET
        {
            get
            {
                return ID_Ticket;
            }
            set
            {
                ID_Ticket = value;
            }
        }
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
        public decimal PRICE_TICKET
        {
            get
            {
                return Price_Ticket;
            }
            set
            {
                Price_Ticket = value;
            }
        }
        public DateTime DATETIME_TICKET
        {
            get
            {
                return DateTime_Ticket;
            }
            set
            {
                DateTime_Ticket = value;
            }
        }
        public string SEAT_TICKET
        {
            get
            {
                return Seat_Ticket;
            }
            set
            {
                Seat_Ticket = value;
            }
        }
        public string CLASS_TICKET
        {
            get
            {
                return Class_Ticket;
            }
            set
            {
                Class_Ticket = value;
            }
        }
        // Properties Flight
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
        public int  EMPTY_SEAT
        {
            get
            {
                return Empty__Seat;
            }
            set
            {
                Empty__Seat = value;
            }
        }

        public int BOOK_SEAT { get => Booked_Seat; set => Booked_Seat = value; }




        // Constructor
        public Ticket_Flight() { }
        public Ticket_Flight(int id, decimal price, DateTime datetime, string seat, string class_ticket, int id_flight)
        {
            this.ID_TICKET = id;
            this.PRICE_TICKET = price;
            this.DATETIME_TICKET = datetime;
            this.SEAT_TICKET = seat;
            this.CLASS_TICKET = class_ticket;
            this.ID_FLIGHT = id_flight;
        }
    }
}
