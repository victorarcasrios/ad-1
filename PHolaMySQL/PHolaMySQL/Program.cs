using System;
using MySql.Data.MySqlClient;
using System.Data;

namespace PHolaMySQL
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string connectionString =
				"Server=localhost;"+
				"Database=dbprueba;"+
				"User ID=root;"+
				"Password=sistemas";
			MySqlConnection mySqlConnection = new MySqlConnection (connectionString);

			mySqlConnection.Open ();

			Console.WriteLine ("Opciones:\n1.Consultar\n2.Modificar\n");
			string respuesta = Console.ReadLine ();
			if (respuesta == "1") {DataReader (mySqlConnection);}
			if (respuesta == "2") {DataWriter (mySqlConnection);}

			mySqlConnection.Close ();

			Console.WriteLine ("\n\nError 404 not found");

		}

		public static void DataReader (MySqlConnection mySqlConnection)
		{
			MySqlCommand mySqlCommand = mySqlConnection.CreateCommand ();
			mySqlCommand.CommandText = "SELECT * FROM categoria";

			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader ();

			Console.WriteLine ("FieldCount = {0}", mySqlDataReader.FieldCount);
			for (int index = 0; index < mySqlDataReader.FieldCount; index++) {
				Console.WriteLine ("Column {0} = {1}", index, mySqlDataReader.GetName (index));

			}

		}

		public static void DataWriter (MySqlConnection mySqlConnection)
		{
			MySqlCommand mySqlCommand = mySqlConnection.CreateCommand ();
			mySqlCommand.CommandText = 
				string.Format ("INSERT INTO categoria (nombre) VALUES ('{0}')", DateTime.Now);

			mySqlCommand.ExecuteNonQuery ();

		}

	}
}
