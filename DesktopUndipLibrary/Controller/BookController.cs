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
    internal class BookController : Model.Connection
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

        public DataTable selectBook(MySqlCommand command)
        {
            DataTable data = new DataTable();
            try
            {
                string tampil = "SELECT * FROM Book";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }
        public void addedBook(string id, string title, string author, string year, int stock, string collection, string shelf)
        {
            string add = "INSERT INTO Book VALUES(" + "@BookId,@Title,@Author,@IssueYear,@Stock,@CollectionId,@ShelfId)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(add, GetConn());
                cmd.Parameters.Add("@BookId", MySqlConnector.MySqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@Title", MySqlConnector.MySqlDbType.VarChar).Value = title;
                cmd.Parameters.Add("@Author", MySqlConnector.MySqlDbType.VarChar).Value = author;
                cmd.Parameters.Add("@IssueYear", MySqlConnector.MySqlDbType.Int32).Value = year;
                cmd.Parameters.Add("@Stock", MySqlConnector.MySqlDbType.Int32).Value = stock;
                cmd.Parameters.Add("@CollectionId", MySqlConnector.MySqlDbType.VarChar).Value = collection;
                cmd.Parameters.Add("@ShelfId", MySqlConnector.MySqlDbType.VarChar).Value = shelf;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Adding Data Failed " + ex.Message);
            }
        }
        public void deleteBook(string id)
        {
            string delete = "DELETE FROM Book WHERE BookId=" + id;
            try
            {
                cmd = new MySqlConnector.MySqlCommand(delete, GetConn());
                cmd.Parameters.Add("BookId", MySqlConnector.MySqlDbType.VarChar).Value = id;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete Failed" + ex.Message);

            }
        }
        public void updateBook(string id, string title, string author, int year, int stock, string collection, string shelf)
        {
            string update = "UPDATE Book SET " + "BookId=@BookId,Title=@Title,Author=@Author, IssueYear=@IssueYear, Stock=@Stock, CollectionId=@CollectionId, ShelfId=@ShelfId " + "WHERE BookId=" + id;
            try
            {
                cmd = new MySqlConnector.MySqlCommand(update, GetConn());
                cmd.Parameters.Add("@BookId", MySqlConnector.MySqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@Title", MySqlConnector.MySqlDbType.VarChar).Value = title;
                cmd.Parameters.Add("@Author", MySqlConnector.MySqlDbType.VarChar).Value = author;
                cmd.Parameters.Add("@IssueYear", MySqlConnector.MySqlDbType.Int32).Value = year;
                cmd.Parameters.Add("@Stock", MySqlConnector.MySqlDbType.Int32).Value = stock;
                cmd.Parameters.Add("@CollectionId", MySqlConnector.MySqlDbType.VarChar).Value = collection;
                cmd.Parameters.Add("@ShelfId", MySqlConnector.MySqlDbType.VarChar).Value = shelf;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Data Failed" + ex.Message);
            }
        }
        public DataTable searchBook(string search)
        {
            DataTable table = new DataTable();
            try
            {
                MySqlCommand command = new MySqlCommand(
                    "SELECT * FROM Book WHERE CONCAT(BookId, Title, Author," +
                    "IssueYear, Stock, CollectionId, ShelfId)LIKE '%" + search + "%'", connect.GetConn());
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
