using System;
using System.Collections;
using System.Text;
using System.Data;
using System.Data.SQLite;

namespace FenixDatabaseSoftware
{
    class DataAccess
    {
        public DataAccess()
        {
        }

        public Boolean update_database(ArrayList listSoftware)
        {
            Boolean response = false;

            Connection connection = new Connection();
            connection.open();

            string sql_drop = "DROP TABLE IF EXISTS software;";

            SQLiteCommand cmd_drop = new SQLiteCommand(sql_drop, connection.connection);
            cmd_drop.ExecuteNonQuery();

            string sql_create_table = "CREATE TABLE software(id_software integer PRIMARY KEY autoincrement,name nvarchar(100),link nvarchar(100));";

            SQLiteCommand cmd_create = new SQLiteCommand(sql_create_table, connection.connection);
            cmd_create.ExecuteNonQuery();

            try
            {
                foreach (Software software in listSoftware)
                {
                    string name = software.pName;
                    string link = software.pLink;

                    var query = new SQLiteCommand("INSERT INTO software(name, link) VALUES (@p0, @p1)", connection.connection);

                    query.Parameters.AddWithValue("@p0", software.pName);
                    query.Parameters.AddWithValue("@p1", software.pLink);

                    query.ExecuteNonQuery();
                }

                response = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            connection.close();

            return response;
        }

        public ArrayList read_database()
        {
            ArrayList listSoftware = new ArrayList();
            Connection connection = new Connection();
            connection.open();
            connection.command.CommandText = "SELECT id_software, name, link FROM software";
            var reader = connection.command.ExecuteReader();
            while (reader.Read())
            {
                Software software = new Software();
                if (!reader.IsDBNull(0))
                {
                    software.pId_software = reader.GetInt32(0);
                }
                if (!reader.IsDBNull(1))
                {
                    software.pName = reader.GetString(1);
                }
                if (!reader.IsDBNull(2))
                {
                    software.pLink = reader.GetString(2);
                }
                listSoftware.Add(software);
            }
            connection.close();
            return listSoftware;
        }
    }
}
