using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp8.Entities;

namespace WindowsFormsApp8.DataAccessLayer
{
    public static class IteamsDAL
    {
        private static string connectionString = "Data Source=.; " +
          "Initial Catalog = PersonalShopping; Integrated Security = True";

        private static SqlConnection connection = new SqlConnection(connectionString);

        public static void CreateItem(Item item)
        {
            string commandText = $"Insert into Items values('{item.ItemName}','{item.ItemUnit}','{item.ItemId}','{item.Quntity}')";
            SqlCommand command = new SqlCommand(commandText, connection);
            connection.Open();
            connection.Close();
            command.ExecuteNonQuery();
        }

        public static void UpdateItem(Item item)
        {
            string commandText = $"Update SystemItems Set " +
               $"ItemName='{item.ItemName}'" +
               $"ItemUnit='{item.ItemUnit}'" +
               $"Quntity='{item.Quntity}'" +
               $"UserId='{item.UserId}'";

            SqlCommand command = new SqlCommand(commandText, connection);
            connection.Open();
            connection.Close();
            command.ExecuteNonQuery();

        }
        public static void DeleteItem(Item item)
        {
            string commandText = $"Delet from Items where ItemId ={item.ItemId}";

            SqlCommand command = new SqlCommand(commandText, connection);
            connection.Open();
            connection.Close();
            command.ExecuteNonQuery();
        }
        public static DataTable GetAllItems()
        {
            string commandText = $"Select * from SystemItems";
            SqlCommand command = new SqlCommand(commandText, connection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static Item GetItemById(int ItemId)
        {
            Item Item = new Item();

            string commandText = $"Select * from Item Where ItemId={ItemId}";
            SqlCommand command = new SqlCommand(commandText, connection);
            SqlDataReader ItemReader = command.ExecuteReader();
            if (ItemReader.HasRows)
            {
                while (ItemReader.Read())
                {
                    Item.ItemId = ItemReader.GetInt32(0);
                    Item.ItemName = ItemReader.GetString(1);
                    Item.ItemUnit = ItemReader.GetString(2);
                    Item.Quntity = ItemReader.GetDouble(3);
                    Item.UserId = ItemReader.GetInt32(4);
                }
            }
            return Item;

        }
    }
}
