using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamSocVaGuiXe
{
    class Moto
    {
        My_DB mydb = new My_DB();


        //  function to insert a new student
        public bool InsertMoto(int Id, MemoryStream pictureNumberPlate, MemoryStream pictureOwner, string name, string address, string phone, int timeRent, DateTime dateRent, string type)
        {
            SqlCommand command = new SqlCommand("INSERT INTO dbo.Moto(Id,ImageNumberPlate,ImageOwner,Name,Address, Phone,TimeRent,DateRent,Type)" +
                " VALUES (@id,@ib, @io, @name,@add, @phone, @timerent, @daterent, @type)", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@ib", SqlDbType.Image).Value = pictureNumberPlate.ToArray();
            command.Parameters.Add("@io", SqlDbType.Image).Value = pictureOwner.ToArray();
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@add", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@timerent", SqlDbType.Int).Value = timeRent;
            command.Parameters.Add("@daterent", SqlDbType.DateTime).Value = dateRent;
            command.Parameters.Add("@type", SqlDbType.VarChar).Value = type;

            mydb.OpenConnection();

            // xuất hiện bug :Cannot insert explicit value for identity column in table 'Bike' when IDENTITY_INSERT is set to OFF.'
            //You can turn on identity insert on the table
            //like this so that you can specify your own identity values.

            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.CloseConnection();
                return true;
            }
            else
            {
                mydb.CloseConnection();
                return false;
            }
        }
        // trả về bảng các giá trị 
        public DataTable getMoto(SqlCommand command)
        {
            command.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool UpdateMoto(int Id, string name, string address, string phone, int time, DateTime date, string type, MemoryStream imageNumberPlate, MemoryStream imageOwner)
        {

            SqlCommand command = new SqlCommand("UPDATE dbo.Moto SET Name=@name,Address=@address,Phone=@Phone, TimeRent=@time,DateRent=@date,Type=@type," +
                "ImageNumberPlate=@imagebike,ImageOwner=@imageowner WHERE Id=@id", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@time", SqlDbType.Int).Value = time;
            command.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
            command.Parameters.Add("@type", SqlDbType.VarChar).Value = type;
            command.Parameters.Add("@imagebike", SqlDbType.Image).Value = imageNumberPlate.ToArray();
            command.Parameters.Add("@imageowner", SqlDbType.Image).Value = imageOwner.ToArray();

            mydb.OpenConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.CloseConnection();
                return true;
            }
            else
            {
                mydb.CloseConnection();
                return false;
            }
        }
        public bool deleteMoto(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM dbo.Moto WHERE id = @id", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            mydb.OpenConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.CloseConnection();
                return true;
            }
            else
            {
                mydb.CloseConnection();
                return false;
            }
        }
        int execCount(string query)
        {
            SqlCommand command = new SqlCommand(query, mydb.GetConnection);
            mydb.OpenConnection();

            int count = (int)command.ExecuteScalar();
            mydb.CloseConnection();

            return count;
        }
        public int totalSlot()
        {
            return execCount("SELECT COUNT(*) FROM dbo.Moto");
        }
    }
}

