using DesktopUndipLibrary.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopUndipLibrary.Controller
{
    internal class RackController : Model.Connection
    {
        private Connection connect = new Connection();
        public DataTable getList(MySqlCommand command)
        {
            command.Connection = connect.GetConn();
            DataTable table = new DataTable();
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return table;
        }
        public DataTable selectRack(MySqlCommand command)
        {
            DataTable data = new DataTable();
            try
            {
                string tampil = "SELECT * FROM Rack";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }
        public void addedRack(string id, string name)
        {
            string add = "INSERT INTO Rack VALUES(" + "@Id,@Namee)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(add, GetConn());
                cmd.Parameters.Add("@Id", MySqlConnector.MySqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@Namee", MySqlConnector.MySqlDbType.VarChar).Value = name;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Adding Data Failed " + ex.Message);
            }
        }
        public void deleteRack(string id)
        {
            string delete = "DELETE FROM Rack WHERE Id=" + id;
            try
            {
                cmd = new MySqlConnector.MySqlCommand(delete, GetConn());
                cmd.Parameters.Add("Id", MySqlConnector.MySqlDbType.VarChar).Value = id;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete Failed" + ex.Message);
            }
        }
    }
}