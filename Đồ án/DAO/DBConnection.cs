using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Reflection;

namespace Project
{
    class DBConnection
    {
        private static DBConnection Instance;
        public static DBConnection INSTANCE
        {
            get
            {
                if (Instance == null)
                    Instance = new DBConnection();
                return DBConnection.Instance;
            }
            private set
            {
                DBConnection.Instance = value;
            }
        }



        public string cn = @"Data Source=DESKTOP-2K9B653;Initial Catalog=FlightManagement_Demo_2;Integrated Security=True";
        public void connect()
        { 
            SqlConnection con = new SqlConnection(cn);
            try
            {
                con.Open();
                MessageBox.Show("Kết nối thành công", "Kết nối", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception )
            {
                MessageBox.Show("Không kết nối thành công", "Kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            con.Dispose();
            con = null;

        }



        /* public void disconnect()   
{
    con.Close();
    con.Dispose();
    con = null;
}*/
        public DataTable ExecuteQuerry(string querry, object[] parameter = null)
        {
            
            DataTable data = new DataTable();
            using (SqlConnection con = new SqlConnection(cn))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(querry, con);
                if (parameter != null)
                {
                    string[] listPara = querry.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@')== true)
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
                Adapter.Fill(data);
                con.Close();
            }
            return data;
        }
        public int ExecuteNoneQuerry(string querry, object[] parameter = null)
        {

            int data = 0;
            using (SqlConnection con = new SqlConnection(cn))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(querry, con);
                if (parameter != null)
                {
                    string[] listPara = querry.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@') == true)
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteNonQuery();
                con.Close();
            }
            return data;
        }
        public  List<T> ConvertDataTable<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }
        private T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else
                        continue;
                }
            }
            return obj;
        }
        public List<T> ExcuteQueryToList<T> (string query, object[] parameter = null)
        {
            List<T> t = new List<T>();
            try
            {
                // string query = "select ID_Ticket as ID_TICKET, tien_thanh_toan as PRICE_TICKET, Ticket.ngay_dat_ve as DATETIME_TICKET from Ticket where TIcket.ID_Customer = 1";                
                t = DBConnection.INSTANCE.ConvertDataTable<T>(DBConnection.INSTANCE.ExecuteQuerry(query, parameter));

            }
            catch (Exception) { System.Windows.Forms.MessageBox.Show("ErroConvertToList", "Erro Convert To List", System.Windows.Forms.MessageBoxButtons.OK); }
            return t;
        }

    }
}
