using CyberSecurityChatbot;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace CyberSecurityChatbot
{
    public class DatabaseHelper
    {
        private string connectionString =
            "server=localhost;database=cybersecuritychatbot;uid=root;pwd=gdy#86r4@#fbd28t1*;";

        public void AddTask(TaskItem task)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"INSERT INTO Tasks
                                (Title,Description,Reminder,Completed)
                                VALUES
                                (@Title,@Description,@Reminder,@Completed)";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Title", task.Title);
                cmd.Parameters.AddWithValue("@Description", task.Description);
                cmd.Parameters.AddWithValue("@Reminder", task.Reminder);
                cmd.Parameters.AddWithValue("@Completed", task.Completed);

                cmd.ExecuteNonQuery();
            }
        }

        public List<TaskItem> GetTasks()
        {
            List<TaskItem> tasks = new List<TaskItem>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM Tasks";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    TaskItem task = new TaskItem();

                    task.Id = Convert.ToInt32(reader["Id"]);
                    task.Title = reader["Title"].ToString();
                    task.Description = reader["Description"].ToString();

                    if (reader["Reminder"] != DBNull.Value)
                        task.Reminder = Convert.ToDateTime(reader["Reminder"]);

                    task.Completed = Convert.ToBoolean(reader["Completed"]);

                    tasks.Add(task);
                }
            }

            return tasks;
        }

        public void CompleteTask(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query =
                    "UPDATE Tasks SET Completed = TRUE WHERE Id=@Id";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Id", id);

                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteTask(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query =
                    "DELETE FROM Tasks WHERE Id=@Id";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Id", id);

                cmd.ExecuteNonQuery();
            }
        }
    }
}