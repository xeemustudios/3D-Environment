using UnityEngine;
using System;
using System.Collections;
// For SQLite
using System.Data;
using Mono.Data.SqliteClient;

public class Registration_Data : MonoBehaviour {
	public string Name;
	public string Age;
	public string Email_ID;
	public string Education_Level;
	public string Date;
	public string Password;
	public string Confirm_Password;
	public string Sex;
	public string Refrence;


	public GUISkin guiSkin ;
	public GUIStyle header1Style;
	public GUIStyle header2Style;
	public GUIStyle header2ErrorStyle;
	public GUIStyle formFieldStyle;

	// Use this for initialization
	void Start () {
		audio.Play ();


	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI(){

			int screenWidth = Screen.width;
			int  screenHeight = Screen.height;
			
			int xShift = (screenWidth - 360)/2;
			int yShift = (screenHeight - 300)/2;
			
			//GUI.skin = guiSkin;
			
			
			// Message label:
			GUI.Label(new Rect(0, yShift + 0, screenWidth, 30), "Enter Registration Data", header2Style);
			
			// Login label and text filed:
			GUI.Label(new Rect(xShift, yShift + 50, 100, 30), "Name:", formFieldStyle);
			Name = GUI.TextField(new Rect(xShift + 110, yShift + 50, 250, 30), Name, 16);
			
			// Password label and text filed:
			GUI.Label(new Rect(xShift, yShift + 100, 100, 30), "Password:", formFieldStyle);
			Password = GUI.PasswordField(new Rect(xShift + 110, yShift + 100, 250, 30), Password, "*"[0], 16);
			
			// Confirm password label and text filed:
			GUI.Label(new Rect(xShift - 60, yShift + 150, 150, 30), "Confirm Password:", formFieldStyle);
			Confirm_Password = GUI.PasswordField(new Rect(xShift + 110, yShift + 150, 250, 30), Confirm_Password, "*"[0], 16);
			
			// Email label and text filed::
			GUI.Label(new Rect(xShift, yShift + 200, 100, 30), "Your Email:", formFieldStyle);
			Email_ID = GUI.TextField(new Rect(xShift + 110, yShift + 200, 250, 30), Email_ID, 32);
			
		   GUI.Label(new Rect(xShift, yShift + 250, 100, 30), "AGE:", formFieldStyle);
		   Age= GUI.TextField(new Rect(xShift + 110, yShift + 250, 250, 30), Age, 32);

		   GUI.Label(new Rect(xShift, yShift + 300, 100, 30), "EDUCATION:", formFieldStyle);
		   Education_Level= GUI.TextField(new Rect(xShift + 110, yShift + 300, 250, 30), Education_Level, 32);
			
		   GUI.Label(new Rect(xShift, yShift + 350, 100, 30), "SEX:", formFieldStyle);
		   Sex= GUI.TextField(new Rect(xShift + 110, yShift + 350, 250, 30), Sex, 32);

		// Register button:
			if(GUI.Button(new Rect(xShift + 50, yShift + 400, 120, 30), "Register")) {
			DataBase ();
			Application.LoadLevel("Main_Menu");
			}
			
			// Cancel button:
			if(GUI.Button(new Rect(xShift + 190, yShift + 400, 120, 30), "Cancel")) {
			Application.LoadLevel("Main_Menu");
			}
			

		}

	void DataBase(){
		string _strDBName = "URI=file:ENEMY_DATABASE.db";
		
		IDbConnection _connection = new SqliteConnection(_strDBName);
		
		IDbCommand _command = _connection .CreateCommand();
		
		string sql;
		
		
		
		_connection .Open();
		

		
		
		sql = "INSERT INTO highscores (name, password, email, age, education, sex, d_o_e, score) VALUES ('"+Name+"', '"+Password+"', '"+Email_ID+"',"+Age+", '"+Education_Level+"', '"+Sex+"', '"+Date+"', 5000)";
		
		_command.CommandText = sql;
		
		_command.ExecuteNonQuery();
		
		
		
		
		
		
		sql = "select * from highscores order by score desc";
		
		_command.CommandText = sql;
		
		IDataReader _reader = _command.ExecuteReader();
		
		while (_reader.Read())
			
			Debug.Log("****** Name: " + _reader["name"] + "\tPassword: " + _reader["password"] + "\tEmail: " + _reader["email"]+ "\tAge: " + _reader["age"]+ "\tEducation: " + _reader["education"]+ "\tSex: " + _reader["sex"]+ "\tD_O_E: " + _reader["d_o_e"]+ "\tScore: " + _reader["score"]);
		
		
		
		_reader.Close();
		
		_reader = null;
		
		_command.Dispose();
		
		_command = null;
		
		_connection .Close();
		
		_connection = null;
		

		
	}

}
