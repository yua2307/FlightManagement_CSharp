using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đồ_án
{
    class Ticket
    {
        // Fields
        private int ID_Ticket;
        private decimal Price_Ticket;
        private DateTime DateTime_Ticket;
        private string Seat_Ticket;
        private string Class_Ticket;
        private int ID_Flight;
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
       
        // Constructor
        public Ticket() { }
        public Ticket(int id, decimal price, DateTime datetime, string seat, string class_ticket, int id_flight)
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
