using System;
using MySql.Data.MySqlClient;
using System.Data;

namespace PHolaMySQL
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("Contraseña para usuario root: " );
			string password = Console.ReadLine ();

			string connectionString =
				"Server=localhost;"+
				"Database=dbprueba;"+
				"User ID=root;"+
				"Password="+password;
			MySqlConnection mySqlConnection = new MySqlConnection (connectionString);

			mySqlConnection.Open ();

			Console.WriteLine ("\nOpciones:\n1.Consultar\n2.Modificar\n");
			string respuesta = Console.ReadLine ();
			if (respuesta == "1") {DataReader (mySqlConnection);}
			if (respuesta == "2") {DataWriter (mySqlConnection);}
			if (respuesta != "1" && respuesta != "2")
				{Console.WriteLine ("\n\nError 404 not found");}

			mySqlConnection.Close ();

		}

		public static void DataReader (MySqlConnection mySqlConnection)
		{
			MySqlCommand mySqlCommand = mySqlConnection.CreateCommand ();
			mySqlCommand.CommandText = "SELECT * FROM categoria";

			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader ();

			Console.WriteLine ("\nFieldCount = {0}", mySqlDataReader.FieldCount);
			for (int index = 0; index < mySqlDataReader.FieldCount; index++) {
				Console.WriteLine ("Column {0} = {1}", index, mySqlDataReader.GetName (index));

			}

			while (mySqlDataReader.Read()) 
			{
				object id = mySqlDataReader ["id"];
				object nombre = mySqlDataReader ["nombre"];

				Console.Write ("\n{0}, {1}", id, nombre);

			}

			mySqlDataReader.Close ();

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
