using DesktopUndipLibrary.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopUndipLibrary.Controller
{
    internal class TransactionController : Model.Connection
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
        public DataTable selectTransaction(MySqlCommand command)
        {
            DataTable data = new DataTable();
            try
            {
                string tampil = "SELECT * FROM Transactionn";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }

        public void addedTransaction(string id, DateTime loan, DateTime returnid, string name, string member, string book, string inform)
        {
            string add = "INSERT INTO Transactionn VALUES (@Id, @LoanDate, @ReturnDate, @Namee, @MemberId, @BookId, @Information)";
            string stockreduced = "UPDATE Book SET Stock = Stock - 1 WHERE BookId = @BookId";
            try
            {
                using (MySqlConnection conn = GetConn())
                {
                    using (MySqlCommand cmd = new MySqlCommand(add, conn))
                    {
                        cmd.Parameters.Add("@Id", MySqlDbType.VarChar).Value = id;
                        cmd.Parameters.Add("@LoanDate", MySqlDbType.Date).Value = loan;
                        cmd.Parameters.Add("@ReturnDate", MySqlDbType.Date).Value = returnid;
                        cmd.Parameters.Add("@Namee", MySqlDbType.VarChar).Value = name;
                        cmd.Parameters.Add("@MemberId", MySqlDbType.VarChar).Value = member;
                        cmd.Parameters.Add("@BookId", MySqlDbType.VarChar).Value = book;
                        cmd.Parameters.Add("@Information", MySqlDbType.VarChar).Value = inform;
                        cmd.ExecuteNonQuery();
                    }

                    using (MySqlCommand cmd = new MySqlCommand(stockreduced, conn))
                    {
                        cmd.Parameters.Add("@BookId", MySqlDbType.VarChar).Value = book;

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Adding Data Failed " + ex.Message);
            }
        }

        public void updateTransaction(string id, DateTime loan, DateTime returnid, string name, string member, string book, string inform)
        {
            if (inform.Equals("Diperpanjang", StringComparison.OrdinalIgnoreCase))
            {
                string update = "UPDATE Transactionn SET LoanDate=@LoanDate, ReturnDate=@ReturnDate, Namee=@Namee, MemberId=@MemberId, BookId=@BookId, Information=@Information WHERE Id=@Id";
                string stockreduced = "UPDATE Book SET Stock = Stock WHERE BookId = @BookId";
                try
                {
                    using (MySqlConnector.MySqlConnection conn = GetConn())
                    {
                        using (MySqlConnector.MySqlCommand cmd = new MySqlConnector.MySqlCommand(update, conn))
                        {
                            cmd.Parameters.Add("@Id", MySqlDbType.VarChar).Value = id;
                            cmd.Parameters.Add("@LoanDate", MySqlDbType.Date).Value = loan;
                            cmd.Parameters.Add("@ReturnDate", MySqlDbType.Date).Value = returnid;
                            cmd.Parameters.Add("@Namee", MySqlDbType.VarChar).Value = name;
                            cmd.Parameters.Add("@MemberId", MySqlDbType.VarChar).Value = member;
                            cmd.Parameters.Add("@BookId", MySqlDbType.VarChar).Value = book;
                            cmd.Parameters.Add("@Information", MySqlDbType.VarChar).Value = inform;

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Data updated successfully.");
                            }
                            else
                            {
                                MessageBox.Show("No rows updated. ID not found.");
                            }
                        }

                        using (MySqlConnector.MySqlCommand cmd = new MySqlConnector.MySqlCommand(stockreduced, conn))
                        {
                            cmd.Parameters.Add("@BookId", MySqlDbType.VarChar).Value = book;
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update Data Failed " + ex.Message);
                }
            }
            else if (inform.Equals("Dikembalikan", StringComparison.OrdinalIgnoreCase))
            {
                string update = "UPDATE Transactionn SET LoanDate=@LoanDate, ReturnDate=@ReturnDate, Namee=@Namee, MemberId=@MemberId, BookId=@BookId, Information=@Information WHERE Id=@Id";
                string stockreduced = "UPDATE Book SET Stock = Stock + 1 WHERE BookId = @BookId";
                try
                {
                    using (MySqlConnector.MySqlConnection conn = GetConn())
                    {
                        using (MySqlConnector.MySqlCommand cmd = new MySqlConnector.MySqlCommand(update, conn))
                        {
                            cmd.Parameters.Add("@Id", MySqlConnector.MySqlDbType.VarChar).Value = id;
                            cmd.Parameters.Add("@LoanDate", MySqlConnector.MySqlDbType.Date).Value = loan;
                            cmd.Parameters.Add("@ReturnDate", MySqlConnector.MySqlDbType.Date).Value = returnid;
                            cmd.Parameters.Add("@Namee", MySqlConnector.MySqlDbType.VarChar).Value = name;
                            cmd.Parameters.Add("@MemberId", MySqlConnector.MySqlDbType.VarChar).Value = member;
                            cmd.Parameters.Add("@BookId", MySqlConnector.MySqlDbType.VarChar).Value = book;
                            cmd.Parameters.Add("@Information", MySqlConnector.MySqlDbType.VarChar).Value = inform;
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Data updated successfully.");
                            }
                            else
                            {
                                MessageBox.Show("No rows updated. ID not found.");
                            }
                        }

                        using (MySqlConnector.MySqlCommand cmd = new MySqlConnector.MySqlCommand(stockreduced, conn))
                        {
                            cmd.Parameters.Add("@BookId", MySqlConnector.MySqlDbType.VarChar).Value = book;
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update Data Failed " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Wrong Information");
            }
        }

        public void deleteTransaction(string id)
        {
            string delete = "DELETE FROM Transactionn WHERE Id=" + id;
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

        public DataTable searchTransaction(string search)
        {
            DataTable table = new DataTable();
            try
            {
                MySqlCommand command = new MySqlCommand(
                    "SELECT * FROM Transaction WHERE CONCAT(Id, LoanDate, ReturnDate," +
                    "Namee, MemberId, BookId, Information)LIKE '%" + search + "%'", connect.GetConn());
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