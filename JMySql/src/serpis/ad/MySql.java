package serpis.ad;

import java.util.Scanner;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class MySql
{
	public static void main(String[] args) throws ClassNotFoundException, SQLException
	{
		//Class.forName("com.mysql.jdbc.Driver"); NECESSARY on TYPE 3 or less
		Scanner scan = new Scanner(System.in);
		String user = ""; String pwd = "";
		
		System.out.print("Hello MySql.\nUser for new connection: ");
		user = scan.nextLine();
		
		System.out.print("Password for user " +user+ ": ");
		pwd = scan.nextLine();
		
		Connection connection = DriverManager.getConnection(
				"jdbc:mysql://localhost/dbprueba?user=" +user+ "&password=" +pwd);
		
		Statement statement = connection.createStatement();
		ResultSet resultSet = statement.executeQuery("SELECT * FROM categoria");
		
		while(resultSet.next())
		{
			System.out.printf("id = %s \t nombre = %s \n", resultSet.getObject("id"), resultSet.getObject("nombre"));
			
		}
		
		resultSet.close();
		statement.close();
		connection.close();
		
	}

}
