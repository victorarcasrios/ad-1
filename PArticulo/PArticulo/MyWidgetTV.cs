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
		private IDbCommand dbCommand;
		private IDataReader dataReader;

		private List<string> tablas = new List<string> ();
		private List<string> colsArticulo = new List<string> ();
		private List<string> colsCategoria = new List<string> ();
		private List<string> rowValues = new List<string> ();

		public MyWidgetTV (string str)
		{
			try{
				/*
				AppendColumn ("id", new CellRendererText(), "text", 0);
				AppendColumn ("nombre", new CellRendererText(), "text", 1);
				Model = new ListStore (typeof (long), typeof (string));

				((ListStore)Model).AppendValues (1L, "Uno");
				((ListStore)Model).AppendValues (2L, "Dos");
				((ListStore)Model).AppendValues (3L, "Tres");
				Visible = true;
				*/

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
					for (int i = 0; i < colsArticulo.Count; i++){
						setRowValues (i, str);
						((ListStore)Model).AppendValues (
							rowValues[0], rowValues[1], rowValues[2], rowValues[3]);

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

					while (this.dataReader.Read()){
						if (tabla == "articulo"){
							this.colsArticulo.Add (this.dataReader [0].ToString ());
						}
						if (tabla == "categoria"){
							this.colsCategoria.Add (this.dataReader [0].ToString ());
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
				Console.WriteLine ("ROW " +row);
				for (int i = 0; i < colsArticulo.Count; i++){
					this.dbCommand = App.Instance.DbConnection.CreateCommand ();
					dbCommand.CommandText = String.Format (
						"SELECT " +colsArticulo[i]+ " FROM `" +tab+ "`");
					this.dataReader = dbCommand.ExecuteReader ();
					Console.WriteLine ("I index " +i);
					int k = 0;
					while (this.dataReader.Read ()){Console.WriteLine ("Reader");
						for (int j = 0; j <= row; j++){Console.WriteLine ("J index " +j);
							if (row == k){Console.WriteLine ("K index " +k);
								this.rowValues.Add (this.dataReader[0].ToString ());
							}
							k++;

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
		private string capitalize(string str)
		{
			if (str == null){ return null;}
			if (str.Length > 1){ return char.ToUpper(str[0]) + str.Substring(1);}
			return str.ToUpper();

		}

	}

}

