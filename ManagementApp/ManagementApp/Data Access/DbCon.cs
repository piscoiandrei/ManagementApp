using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ManagementApp
{
    public class DbCon
    { 
        private string connectionString = Global.conStr;
        public DbCon() { }
        // user related

        public void DeleteUser(string id)
        {
            Guid guid = new Guid(id);
            using (var con = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand("DELETE FROM users WHERE id = @id", con))
                {
                    cmd.Parameters.AddWithValue("@id", guid);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool Login(string email, string pw)
        {
            bool ok = false;
            MyUser user = new MyUser();

            using (var con = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand("SELECT * FROM users WHERE email = @email AND pw = @pw",con))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@pw", pw);

                    con.Open();

                    using ( var rdr = cmd.ExecuteReader())
                    {
                        while(rdr.Read())
                        {
                            if(rdr != null)
                            {
                                ok = true;
                                user = new MyUser
                                {
                                    ID = rdr[0].ToString(),
                                    EMAIL = rdr[1].ToString(),
                                    FIRSTNAME = rdr[2].ToString(),
                                    LASTNAME = rdr[3].ToString(),
                                    PASSWORD = rdr[4].ToString(),
                                    MANAGER = Convert.ToBoolean(rdr[5])
                                };
                                break;

                            }
                        }
                    }
                }
            }
            Global.currentUser = user;
            return ok;
        }
        public void InsertUser(string fn, string ln, string email, string pw, bool mng)
        {
            using (var con = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand("INSERT INTO users (email, fname, lname, pw, manager) VALUES (@email, @fname, @lname, @pw, @manager) ", con))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@fname", fn);
                    cmd.Parameters.AddWithValue("@lname", ln);
                    cmd.Parameters.AddWithValue("@pw", pw);
                    cmd.Parameters.AddWithValue("@manager", mng);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateUser(string id, string email, string fn, string ln, string pw, bool mng)
        {
            Guid ID = new Guid(id);
            using (var con = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand("UPDATE users SET email=@email, fname = @fname, lname = @lname, pw = @pw, manager = @manager WHERE id = @id",con))
                {
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@fname",fn);
                    cmd.Parameters.AddWithValue("@lname",ln);
                    cmd.Parameters.AddWithValue("@pw",pw);
                    cmd.Parameters.AddWithValue("@manager",mng);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool CheckUniqueEmail(string email)
        {
            bool ok = true;
            using (var con = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand("SELECT * FROM users WHERE email = @email", con))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    con.Open();

                    using (var rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            if (rdr != null)
                            {
                                ok = false;
                                break;
                            }
                        }
                    }
                }
            }
            return ok;
        }

        public MyUser SearchUserByID(string ID)
        {
            MyUser user = new MyUser();

            using (var con = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand("SELECT * FROM users WHERE id = @id", con))
                {
                    cmd.Parameters.AddWithValue("@id", new Guid(ID));

                    con.Open();

                    using (var rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            if (rdr != null)
                            {
                                user = new MyUser
                                {
                                    ID = rdr[0].ToString(),
                                    EMAIL = rdr[1].ToString(),
                                    FIRSTNAME = rdr[2].ToString(),
                                    LASTNAME = rdr[3].ToString(),
                                    PASSWORD = rdr[4].ToString(),
                                    MANAGER = Convert.ToBoolean(rdr[5])
                                };
                                break;

                            }
                        }
                    }
                }
            }
            return user;
        }

        public MyUser SearchUserByEmail(string email)
        {
            MyUser user = new MyUser();

            using (var con = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand("SELECT * FROM users WHERE email = @email", con))
                {
                    cmd.Parameters.AddWithValue("@email", email);

                    con.Open();

                    using (var rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            if (rdr != null)
                            {
                                user = new MyUser
                                {
                                    ID = rdr[0].ToString(),
                                    EMAIL = rdr[1].ToString(),
                                    FIRSTNAME = rdr[2].ToString(),
                                    LASTNAME = rdr[3].ToString(),
                                    PASSWORD = rdr[4].ToString(),
                                    MANAGER = Convert.ToBoolean(rdr[5])
                                };
                                break;

                            }
                        }
                    }
                }
            }
            return user;
        }
        public List<MyUser> SearchUserByFirstNameOrLastName(string firstName, string lastName)
        {
            MyUser user = new MyUser();
            List<MyUser> list = new List<MyUser>();

            using (var con = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand("SELECT * FROM users WHERE fname = @fname OR lname = @lname", con))
                {
                    cmd.Parameters.AddWithValue("@fname", firstName);
                    cmd.Parameters.AddWithValue("@lname", lastName);

                    con.Open();

                    using (var rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            if (rdr != null)
                            {
                                user = new MyUser
                                {
                                    ID = rdr[0].ToString(),
                                    EMAIL = rdr[1].ToString(),
                                    FIRSTNAME = rdr[2].ToString(),
                                    LASTNAME = rdr[3].ToString(),
                                    PASSWORD = rdr[4].ToString(),
                                    MANAGER = Convert.ToBoolean(rdr[5])
                                };

                                list.Add(user);
                            }
                        }
                    }
                }
            }
            return list;
        }

        public List<MyUser> GetAllUsers()
        {
            MyUser user = new MyUser();
            List<MyUser> list = new List<MyUser>();

            using (var con = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand("SELECT * FROM users", con))
                {
                    con.Open();

                    using (var rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            if (rdr != null)
                            {
                                user = new MyUser
                                {
                                    ID = rdr[0].ToString(),
                                    EMAIL = rdr[1].ToString(),
                                    FIRSTNAME = rdr[2].ToString(),
                                    LASTNAME = rdr[3].ToString(),
                                    PASSWORD = rdr[4].ToString(),
                                    MANAGER = Convert.ToBoolean(rdr[5])
                                };

                                list.Add(user);
                            }
                        }
                    }
                }
            }
            return list;
        }


        //login time related
        public void InsertLogTimes(string email, DateTime dt1, DateTime dt2, int mins)
        {
            using (var con = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand("INSERT INTO logTimes (user_email,login,logout,time_spent) VALUES (@email, @login, @logout, @time_spent) ", con))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@login", dt1);
                    cmd.Parameters.AddWithValue("@logout", dt2);
                    cmd.Parameters.AddWithValue("@time_spent", mins);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Data population from file 
        public void InsertFromCSV()
        {
            string s = @"C:/Users/andrew/Desktop/giantdata.csv";
            using (var reader = new System.IO.StreamReader(s))
            {
                while (!reader.EndOfStream)
                {
                    if (reader != null)
                    {
                        
                        var line = reader.ReadLine().ToString();
                        if (line != null)
                        {
                            var values = line.Split(',');

                            if (values[4] == "0")
                            {
                                new DbCon().InsertUser(values[1], values[2], values[0], values[3], false);
                            }
                            else
                            {
                                new DbCon().InsertUser(values[1], values[2], values[0], values[3], true);
                            }
                        }
                    }
                }
            }
        }

        // task related 


        public void InsertTasksIntoTable(string table, string creatorID, string appointedtoID, string task, string notes, DateTime date, DateTime deadline)
        {
            using (var con = new SqlConnection(connectionString))
            {
                string cmdString = "INSERT INTO " + table + "(creatorID,appointedtoID,task,notes,date,deadline) VALUES (@creatorID,@appointedtoID,@task,@notes,@date,@deadline)";

                using (var cmd = new SqlCommand(cmdString, con))
                {
                    cmd.Parameters.AddWithValue("@table", table);
                    cmd.Parameters.AddWithValue("@creatorID", creatorID);
                    cmd.Parameters.AddWithValue("@appointedtoID", appointedtoID);
                    cmd.Parameters.AddWithValue("@task", task);
                    cmd.Parameters.AddWithValue("@notes", notes);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@deadline", deadline);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteTaskFromTable(string table, string panelID)
        {
            using (var con = new SqlConnection(connectionString))
            {
                string cmdString = "DELETE " + table + " WHERE id = @panelID ";

                using (var cmd = new SqlCommand(cmdString, con))
                {
                    cmd.Parameters.AddWithValue("@panelID", new Guid(panelID));

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
