using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TimeManager.Model
{
    public class ConnectToBase
    {

        public static string connectString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|TimeDB.mdb;";
        public string timeBase = "TimeBase";
        public string userBase = "UserBase";
        public string categoryBase = "Category";
        public string tasksBase = "Tasks";
        private OleDbConnection myConnection;
        //OleDbCommand cmd;


        private OleDbConnection Conection { get { return new OleDbConnection(connectString); } }

        public DataTable GetData(string qyery)
        {
            DataTable table = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                myConnection = Conection;
                using (myConnection)
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(qyery, myConnection))
                {
                    adapter.Fill(ds);
                    table = ds.Tables[0];
                    return table;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return table;
            }
        }


        //public bool RunSQL(string qyery)
        //{
        //    try
        //    {
        //        myConnection = Conection;
        //        cmd = new OleDbCommand();
        //        cmd.CommandType = CommandType.Text;
        //        cmd.CommandText = qyery;
        //        cmd.Connection = myConnection;
        //        myConnection.Open();
        //        cmd.ExecuteNonQuery();
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        return false;
        //    }
        //    finally
        //    {
        //        if (myConnection != null) myConnection.Close();
        //    }
        //}



        int countConnection = 0;
        //Random rand = new Random();

        //MTAThreadAttribute thread = new MTAThreadAttribute();


        private void ConnectTo(bool mErorr = true)
        {
            //InitializeTimerUpdates();
            try
            {


                myConnection = new OleDbConnection(connectString);
                myConnection.Open();  // 15-31 miliseconds

                countConnection = 0;

            }
            catch (Exception ex)
            {

                if (countConnection < 50000)
                {
                    //rand.Next(0, 5);
                    countConnection++;
                    ConnectTo();
                }
                else
                    if (mErorr) MessageBox.Show(ex.Message);
                //return null;
            }
        }




        public DataTable Select(string query, string userName = null)
        {
            try
            {
                //string query = "SELECT * FROM ";
                ConnectTo();

                OleDbCommand cmd = myConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                if (userName != null) cmd.Parameters.AddWithValue("@uName", userName);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                myConnection.Close();

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void Insert(string query)
        {
            try
            {
                ConnectTo();

                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.Connection = myConnection;
                //cmd.Parameters.AddWithValue("@uName", uName);
                //cmd.Parameters.AddWithValue("@breakType", breakType);
                //cmd.Parameters.AddWithValue("@breakNotes", breakNotes);
                //cmd.Parameters.AddWithValue("@startTime", startTime);
                //cmd.Parameters.AddWithValue("@endTime", endTime);
                //cmd.Parameters.AddWithValue("@Is_Active", isActive);
                cmd.ExecuteNonQuery();
                myConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        public void Insert(int uID, string breakType, string breakNotes, string startTime, string endTime, string isActive)
        {
            try
            {
                ConnectTo();

                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO " + timeBase + "(User_ID, Break_Type, Break_Notes, Start_Time, End_Time, Is_Active) VALUES(@uID, @breakType, @breakNotes, @startTime, @endTime, @Is_Active)";

                cmd.Connection = myConnection;
                cmd.Parameters.AddWithValue("@uID", uID);
                cmd.Parameters.AddWithValue("@breakType", breakType);
                cmd.Parameters.AddWithValue("@breakNotes", breakNotes);
                cmd.Parameters.AddWithValue("@startTime", startTime);
                cmd.Parameters.AddWithValue("@endTime", endTime);
                cmd.Parameters.AddWithValue("@Is_Active", isActive);
                cmd.ExecuteNonQuery();
                myConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        public void Updates(string query)
        {
            try
            {
                ConnectTo();

                OleDbCommand cmd = new OleDbCommand(query, myConnection);

                //cmd.Parameters.AddWithValue("@User_Name", userName);
                //cmd.Parameters.AddWithValue("@Break_Notes", breakNotes);
                //cmd.Parameters.AddWithValue("@Break_Type", breakType);
                //cmd.Parameters.AddWithValue("@breakNotesNew", breakNotesNew);
                //cmd.Parameters.AddWithValue("@End_Time", endTime);
                //cmd.Parameters.AddWithValue("@Is_Active", isActive);

                cmd.Connection = myConnection;
                cmd.ExecuteNonQuery();
                myConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        public void Updates(int uID, string startTime, string endTime, string breakType, string breakNotes, string isActive)
        {
            try
            {
                ConnectTo();
                //breakNotesNew = "";
                //OleDbCommand cmd = new OleDbCommand("UPDATE " + timeBase + " SET [End_Time]=@End_Time, [Break_Notes]=@Break_Notes, [Is_Active]=@Is_Active  WHERE [User_ID]=@User_ID", myConnection);

                //cmd.Parameters.AddWithValue("@User_ID", uID);
                //cmd.Parameters.AddWithValue("@Break_Notes", breakNotes);
                ////cmd.Parameters.AddWithValue("@Break_Type", breakType);

                //cmd.Parameters.AddWithValue("@End_Time", endTime);
                ////cmd.Parameters.AddWithValue("@Start_Time", startTime);
                //cmd.Parameters.AddWithValue("@Is_Active", isActive);

                //cmd.Connection = myConnection;
                //cmd.ExecuteNonQuery();
                //myConnection.Close();


                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;   // "' and Start_Time = '" + startTime +
                cmd.CommandText = "UPDATE " + timeBase + " SET Break_Notes = '" + breakNotes + "', End_Time = '" + endTime + "', Is_Active = '0' WHERE  User_ID = @User_ID AND Break_Type ='" + breakType + "' AND (Break_Notes = '(The break is ongoing..)' OR Break_Notes = '(Work is ongoing..)')";
                cmd.Parameters.AddWithValue("@User_ID", uID);
                //cmd.Parameters.AddWithValue("@Is_Active", isActive);
                cmd.Connection = myConnection;
                cmd.ExecuteNonQuery();
                myConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }



        private string ScreenText(string text)
        {
            return text.Replace("'", "''");
        }

        public string Uname()
        {
            UserPrincipal userPrincipal = UserPrincipal.Current;   // ----------------------------------- повне імя користувача
            string uName = userPrincipal.DisplayName;
            return uName;
        }

        public DataTable SelectInfo()  /// ----------------------- ??
        {
            try
            {
                ConnectTo();
                OleDbCommand cmd = myConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                //cmd.CommandText = "SELECT * FROM " + timeBase;
                cmd.CommandText = @"SELECT t1.ID, t1.UserName, t1.Time_Date, @i AS WorkTime, @i:= t1.Time_Date - @i AS Time_Action FROM " + timeBase + @" t1 JOIN(SELECT @i:= 0) var";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                myConnection.Close();

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

       

    }
}
