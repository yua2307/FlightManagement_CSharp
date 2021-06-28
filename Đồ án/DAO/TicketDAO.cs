using Đồ_án;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Class
{
    class TicketDAO
    {

        private static TicketDAO Instance;
        public static TicketDAO INSTANCE
        {
            get
            {
                if (Instance == null)
                    Instance = new TicketDAO();
                return TicketDAO.Instance;
            }
            private set
            {
                TicketDAO.Instance = value;
            }
        }

        public List<Ticket> showAllTicket(string userName, string passWord)
        {
            int id = int.Parse(CustomerDAO.INSTANCE.getID(userName, passWord));
            string query = "select ID_TICKET, ID_FLIGHT,  PRICE_TICKET, DATETIME_TICKET, SEAT_TICKET, CLASS_TICKET from Ticket where Ticket.ID_Customer = @id ";

            return DBConnection.INSTANCE.ExcuteQueryToList<Ticket>(query, new object[] { id });
        }
        public List<object> showAllTicket1(string userName, string passWord)
        {
            LinQDataContext linQ = new LinQDataContext();
            List<object> data = (from u in linQ.Tickets select u).ToList<object>();
            return data;
        }
    }
}