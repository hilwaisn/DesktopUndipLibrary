﻿using DesktopUndipLibrary.Model;
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
    internal class VisitorsController : Model.Connection
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
        public DataTable selectVisitors(MySqlCommand command)
        {
            DataTable data = new DataTable();
            try
            {
                string tampil = "SELECT * FROM Visitors";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }
        public void addedVisitors(string id, string name, string gender, string study, string needs, string search, DateTime date)
        {
            string add = "INSERT INTO Visitors VALUES(" + "@Id,@Namee,@Gender,@StudyProgram,@Needs,@Search,@Datee)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(add, GetConn());
                cmd.Parameters.Add("@Id", MySqlConnector.MySqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@Namee", MySqlConnector.MySqlDbType.VarChar).Value = name;
                cmd.Parameters.Add("@StudyProgram", MySqlConnector.MySqlDbType.Int32).Value = study;
                cmd.Parameters.Add("@Gender", MySqlConnector.MySqlDbType.VarChar).Value = gender;
                cmd.Parameters.Add("@Needs", MySqlConnector.MySqlDbType.Int32).Value = needs;
                cmd.Parameters.Add("@Search", MySqlConnector.MySqlDbType.VarChar).Value = search;
                cmd.Parameters.Add("@Datee", MySqlConnector.MySqlDbType.VarChar).Value = date;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Adding Data Failed " + ex.Message);
            }
        }
        public void deleteVisitors(string id)
        {
            string delete = "DELETE FROM Visitors WHERE Id=@id";
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
        public void updateVisitors(string id, string name, string gender, string study, string needs, string search, DateTime date)
        {
            string update = "UPDATE Visitors SET Namee=@Namee, Gender=@Gender, StudyProgram=@StudyProgram, Needs=@Needs, Search=@Search, Datee=@Datee WHERE Id=@id";
            try
            {
                using (MySqlConnector.MySqlConnection conn = GetConn())
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }
                    using (MySqlConnector.MySqlCommand cmd = new MySqlConnector.MySqlCommand(update, conn))
                    {
                        cmd.Parameters.Add("@Id", MySqlConnector.MySqlDbType.VarChar).Value = id;
                        cmd.Parameters.Add("@Namee", MySqlConnector.MySqlDbType.VarChar).Value = name;
                        cmd.Parameters.Add("@Gender", MySqlConnector.MySqlDbType.VarChar).Value = gender;
                        cmd.Parameters.Add("@StudyProgram", MySqlConnector.MySqlDbType.VarChar).Value = study;
                        cmd.Parameters.Add("@Needs", MySqlConnector.MySqlDbType.VarChar).Value = needs;
                        cmd.Parameters.Add("@Search", MySqlConnector.MySqlDbType.VarChar).Value = search;
                        cmd.Parameters.Add("@Datee", MySqlConnector.MySqlDbType.Date).Value = date;
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Data Failed: " + ex.Message);
            }
        }
        public DataTable searchVisitors(string search)
        {
            DataTable table = new DataTable();
            try
            {
                MySqlCommand command = new MySqlCommand(
                    "SELECT * FROM Visitors WHERE CONCAT(Id, Namee, Gender," +
                    "StudyProgram, Needs, Search, Datee)LIKE '%" + search + "%'", connect.GetConn());
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