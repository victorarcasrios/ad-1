//gitUser> @juankza

using Gtk;
using MySql;
using MySql.Data.MySqlClient;
using SerpisAd;
using System;
using System.Collections.Generic;
using System.Data;

namespace PArticulo
{
	public class MyWidgetTV : TreeView
	{
		//GLOBAL VARS
		private IDbCommand dbCommand;
		private IDataReader dataReader;

		private List<string> tablas = new List<string> ();
		private List<string> colsArticulo = new List<string> ();
		private List<string> colsCategoria = new List<string> ();
		private List<string> rowValues = new List<string> ();

		private int rowsArt;
		private int rowsCat;

<<<<<<< HEAD
		//MAIN FUNCTION
=======
>>>>>>> ef9423867ced2e2c4a0728cfb2e13cdd053f3de4
		public MyWidgetTV (string str)
		{
			try{

				setColumnNames ();
				dataReader.Close ();

				if (str == "articulo"){
					for (int i = 0; i < colsArticulo.Count; i++){
						AppendColumn (
							capitalize (colsArticulo[i].ToString ()),
							new CellRendererText(), "text", i
							);
					}

					Model = new ListStore (
						typeof (string), typeof (string),
						typeof (string), typeof (string)
						);
					for (int i = 0; i < rowsArt; i++){
						setRowValues (i, str);
						((ListStore)Model).AppendValues (
							rowValues[0], rowValues[1], rowValues[2], rowValues[3]);

					}

				}

				if (str == "categoria"){
					for (int i = 0; i < colsCategoria.Count; i++){
						AppendColumn (
							capitalize (colsCategoria[i].ToString ()),
							new CellRendererText(), "text", i
							);
					}

					Model = new ListStore (
						typeof (string), typeof (string)
						);
					for (int i = 0; i < rowsCat; i++){
						setRowValues (i, str);
						((ListStore)Model).AppendValues (
							rowValues[0], rowValues[1]);

					}

				}

				this.Visible = true;

			}
			catch (Exception e){
				Console.WriteLine (e.Message);
			}

		}

		//MY FUNCTIONS
		private void setTableNames (string db)
		{
			try{
				this.dbCommand = App.Instance.DbConnection.CreateCommand ();
				dbCommand.CommandText = String.Format (
					"SHOW TABLES FROM " +db);
				this.dataReader = dbCommand.ExecuteReader ();

				while (this.dataReader.Read()){
					this.tablas.Add (dataReader[0].ToString());

				}

				this.dataReader.Close ();

			}
			catch (MySqlException e){
				Console.WriteLine (e.Message);
			}
			catch (Exception e){
				Console.WriteLine (e.Message);
			}

		}
		private void setColumnNames ()
		{
			try{
				if (tablas.Count == 0){ setTableNames("dbprueba");}
				for (int i = 0; i < tablas.Count; i++){
					string tabla = tablas[i].ToString ();
					this.dbCommand = App.Instance.DbConnection.CreateCommand ();
					dbCommand.CommandText = String.Format (
						"SELECT column_name FROM information_schema.columns " +
						"WHERE table_schema = 'dbprueba' AND table_name = '" +tabla+ "'"
						);
					this.dataReader = dbCommand.ExecuteReader ();

					while (this.dataReader.Read ()){
						if (tabla == "articulo"){
							this.colsArticulo.Add (this.dataReader [0].ToString ());
						}
						if (tabla == "categoria"){
							this.colsCategoria.Add (this.dataReader [0].ToString ());
						}

					}
					this.dataReader.Close ();

					this.dbCommand = App.Instance.DbConnection.CreateCommand ();
					dbCommand.CommandText = String.Format (
						"SELECT COUNT(*) FROM `" +tabla+ "`"
						);
					this.dataReader = dbCommand.ExecuteReader ();
					while (this.dataReader.Read ()){
						if (tabla == "articulo"){
							this.rowsArt = Convert.ToInt32(this.dataReader [0].ToString ());
						}
						if (tabla == "categoria"){
							this.rowsCat = Convert.ToInt32(this.dataReader [0].ToString ());
						}

					}
					this.dataReader.Close ();

				}

			}
			catch (MySqlException e){
				Console.WriteLine (e.Message);
			}
			catch (Exception e){
				Console.WriteLine (e.Message);
			}

		}
		private void setRowValues (int row, string tab)
		{
			try{
				if (this.rowValues.Count != 0){ this.rowValues.Clear ();}
				int col = 0;
				if (tab == "articulo"){ col = colsArticulo.Count;}
				if (tab == "categoria"){ col = colsCategoria.Count;}

				for (int i = 0; i < col; i++){
					this.dbCommand = App.Instance.DbConnection.CreateCommand ();

					string command = "";
					if (tab == "articulo"){
						command = String.Format ("SELECT " +colsArticulo[i]+ " FROM `" +tab+ "`");}
					if (tab == "categoria"){
						command = String.Format ("SELECT " +colsArticulo[i]+ " FROM `" +tab+ "`");}

					dbCommand.CommandText = command;
					this.dataReader = dbCommand.ExecuteReader ();

					int j = 0;
					while (this.dataReader.Read ()){
						if (row == j){
							this.rowValues.Add (this.dataReader[0].ToString ());
						}
						j++;

					}

					this.dataReader.Close ();

				}

			}
			catch (MySqlException e){
				Console.WriteLine (e.Message);
			}
			catch (Exception e){
				Console.WriteLine (e.Message);
			}

		}
		private string capitalize(string str)
		{
			if (str == null){ return null;}
			if (str.Length > 1){ return char.ToUpper(str[0]) + str.Substring(1);}
			return str.ToUpper();

		}

	}

}

