//GitHub>@juankza
package juankza;

import java.util.Scanner;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class Articulo
{
	private static Scanner scan = new Scanner(System.in);
	private static Connection connection = null;
	private static boolean exit = false;
	
	private static void connection(String user, String pwd)
	{
		try{
			connection = DriverManager.getConnection(
					"jdbc:mysql://localhost/dbprueba?user=" +user+ "&password=" +pwd);
			
		}
		catch(Exception e){
			System.out.println("\nUnnable to connect to database.\nError 404.");
			System.exit(0);
			
		}
		
	}
	
	public static void main(String[] args)
	{
		System.out.print("Username: ");
		String user = scan.nextLine();
		
		System.out.print("Password: ");
		String pwd = scan.nextLine();
		
		connection(user, pwd);
		
		while(!exit)
		{
			System.out.print("\n0.Salir\t1.Nuevo\t2.Editar\t3.Eliminar\t4.Visualizar");
			int option = scan.nextInt();
			
			switch(option)
			{
				case 0:{ System.out.print("\nSaliendo..."); exit = true; break;}
				case 1:{ }
				case 2:{ }
				case 3:{ }
				case 4:{ }
				default:{ System.out.print("\nOpcion no encontrada."); break;}
			
			}
			
		}
		
	}

}
