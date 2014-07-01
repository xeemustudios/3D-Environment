using UnityEngine;
using System;
using System.Collections;
// For SQLite
using System.Data;
using Mono.Data.SqliteClient;

public class SQLiteTest : MonoBehaviour {
	String F,L;

	// Use this for initialization
	void Start () {
			 	
				string connectionString = "URI=file:SqliteTestDB.db";
	 	 
				IDbConnection dbcon;
				dbcon = (IDbConnection)new SqliteConnection (connectionString);
				dbcon.Open ();
     
				IDbCommand dbcmd = dbcon.CreateCommand ();
				//String sql="CREATE TABLE MANU(" +
				//"SUBJECT_ID INT PRIMARY KEY NOT NULL," +
				//	"NAME CHAR(50) NOT NULL," +
				//"AGE INT NOT NULL" +
				//	"SCORE INT NOT NULL," +
				//")";
				//String sql = "INSERT INTO MANU (SUBJECT_ID,NAME,AGE,SCORE)"+
				//	"VALUES (1, 'Paul', 30,20000.00 )";

			string sql =
				   "SELECT firstname, lastname " +
				 "FROM employee";

				dbcmd.CommandText = sql;
				dbcmd.ExecuteNonQuery ();
				IDataReader reader = dbcmd.ExecuteReader ();

				while (reader.Read()) {
						string FirstName = reader.GetString (0);
						string LastName = reader.GetString (1);
						// Print to Console
						Debug.Log (FirstName + LastName);
						F = FirstName;
						L = LastName;
//		Debug.Log ("manu");
//	}

						// clean up                                                                                                                                 
						reader.Close ();
						reader = null;
						dbcmd.Dispose ();
						dbcmd = null;
						dbcon.Close ();
						dbcon = null;
	
				}
		}
	void OnGUI(){
		GUI.Label (new Rect (Screen.width * 0.8f, Screen.height * 0.2f, 150f, 50f),F);
		GUI.Label (new Rect (Screen.width * 0.1f, Screen.height * 0.2f, 150f, 50f),L);
	}

	// Update is called once per frame
	void Update () {
	
	}
}
