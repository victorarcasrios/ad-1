using System;
using MySql.Data.MySqlClient;
using System.Data;

namespace PHolaMySQL
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Error 404 not found");

			string connectionString =
				"Server=localhost;"+
				"Database=dbprueba;"+
				"User ID=root;"+
				"Password=sistemas";
			MySqlConnection mySqlConnection = new MySqlConnection (connectionString);

			mySqlConnection.Open ();
			/*
			//Write
			MySqlCommand mySqlCommand = mySqlConnection.CreateCommand ();
			mySqlCommand.CommandText = 
				string.Format ("INSERT INTO categoria (nombre) VALUES ('{0}')", DateTime.Now);

			mySqlCommand.ExecuteNonQuery ();
			*/
			//Read
			MySqlCommand mySqlCommand = mySqlConnection.CreateCommand ();
			mySqlCommand.CommandText = "SELECT * FROM categoria";
			
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader ();

			Console.WriteLine ("FieldCount = {0}", mySqlDataReader.FieldCount);
			for (int index = 0; index < mySqlDataReader.FieldCount; index++) {
				Console.WriteLine ("Column {0} = {1}", index, mySqlDataReader.GetName (index));

			}

			mySqlConnection.Close ();

		}
	}
}
