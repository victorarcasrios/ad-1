//gitUser> @juankza

using MySql.Data.MySqlClient;
using System;
using System.Data;
using PCategoria;

public class App 
{
	private App ()
	{

	}

	private static App instance = new App ();

	public static App Instance {
		get { return instance;}

	}

	private MySqlConnection mySqlConnection;

	public MySqlConnection MySqlConnection {
		get { return mySqlConnection;}
		set { mySqlConnection = value;}

	}

}


