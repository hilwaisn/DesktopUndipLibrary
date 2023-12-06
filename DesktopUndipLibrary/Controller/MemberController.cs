using DesktopUndipLibrary.Model;
using MySqlConnector;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DesktopUndipLibrary.Controller
{
    internal class MemberController : Model.Connection
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

        public DataTable selectMember(MySqlCommand command)
        {
            DataTable data = new DataTable();
            try
            {
                string tampil = "SELECT * FROM Member";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }
        public void addedMember(string id, string name, string studyprogram, string placeofirth, DateTime dateofirth, string telephonenumber, string address)
        {
            string add = "INSERT INTO Member VALUES(" + "@MemberId,@Namee,@StudyProgram,@PlaceofBirth,@DateofBirth,@TelephoneNumber,@Address)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(add, GetConn());
                cmd.Parameters.Add("@MemberId", MySqlConnector.MySqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@Namee", MySqlConnector.MySqlDbType.VarChar).Value = name;
                cmd.Parameters.Add("@StudyProgram", MySqlConnector.MySqlDbType.VarChar).Value = studyprogram;
                cmd.Parameters.Add("@PlaceofBirth", MySqlConnector.MySqlDbType.VarChar).Value = placeofirth;
                cmd.Parameters.Add("@DateofBirth", MySqlConnector.MySqlDbType.Date).Value = dateofirth;
                cmd.Parameters.Add("@TelephoneNumber", MySqlConnector.MySqlDbType.VarChar).Value = telephonenumber;
                cmd.Parameters.Add("@Address", MySqlConnector.MySqlDbType.VarChar).Value = address;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Adding Data Failed " + ex.Message);
            }
        }
        public void deleteMember(string id)
        {
            string delete = "DELETE FROM Member WHERE MemberId=" + id;
            try
            {
                cmd = new MySqlConnector.MySqlCommand(delete, GetConn());
                cmd.Parameters.Add("MemberId", MySqlConnector.MySqlDbType.VarChar).Value = id;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete Failed" + ex.Message);

            }
        }
        public void updateMember(string id, string name, string studyprogram, string placeofirth, DateTime dateofirth, string telephonenumber, string address)
        {
            string update = "UPDATE Member SET " + "MemberId=@MemberId,Namee=@Namee,StudyProgram=@StudyProgram,PlaceofBirth=@PlaceofBirth,DateofBirth=@DateofBirth,TelephoneNumber=@TelephoneNumber,Address=@Address " + "WHERE MemberId=" + id;
            try
            {
                cmd = new MySqlConnector.MySqlCommand(update, GetConn());
                cmd.Parameters.Add("@MemberId", MySqlConnector.MySqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@Namee", MySqlConnector.MySqlDbType.VarChar).Value = name;
                cmd.Parameters.Add("@StudyProgram", MySqlConnector.MySqlDbType.VarChar).Value = studyprogram;
                cmd.Parameters.Add("@PlaceofBirth", MySqlConnector.MySqlDbType.VarChar).Value = placeofirth;
                cmd.Parameters.Add("@DateofBirth", MySqlConnector.MySqlDbType.Date).Value = dateofirth;
                cmd.Parameters.Add("@TelephoneNumber", MySqlConnector.MySqlDbType.VarChar).Value = telephonenumber;
                cmd.Parameters.Add("@Address", MySqlConnector.MySqlDbType.VarChar).Value = address;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Data Failed" + ex.Message);
            }
        }
        public DataTable searchMember(string search)
        {
            DataTable table = new DataTable();
            try
            {
                MySqlCommand command = new MySqlCommand(
                    "SELECT * FROM Member WHERE CONCAT(MemberId, Namee, StudyProgram," +
                    "PlaceofBirth, DateofBirth, TelephoneNumber, Address)LIKE '%" + search + "%'", connect.GetConn());
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return table;
        }
    }
}
