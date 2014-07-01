using UnityEngine;
using System;
using System.Collections;
// For SQLite
using System.Data;
using Mono.Data.SqliteClient;

public class Login_DataBase : MonoBehaviour {
	public string Login_Name;
	public string Login_Password;
	string[] nme = new string[9999];
	string[] pass= new string[9999];

    public GUISkin guiSkin ;
	public GUIStyle header1Style;
	public GUIStyle header2Style;
	public GUIStyle header2ErrorStyle;
	public GUIStyle formFieldStyle;


	// Use this for initialization
	void Start () {
		DataBase ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI(){
				int screenWidth = Screen.width;
				int screenHeight = Screen.height;
		
				int xShift = (screenWidth - 260) / 2;
				int yShift = (screenHeight - 260) / 2;
				//GUI.skin = guiSkin;
		        //GUI.enabled = true;

		
		// Main label:
		GUI.Label(new Rect(0, yShift, screenWidth, 30), "Welcome to the Game", header1Style);
		GUI.Label(new Rect(0, yShift +70, screenWidth, 30), "Enter your Login Name & Password", header2Style);

		GUI.Label(new Rect(xShift, yShift + 120, 100,30), "Name:", formFieldStyle);
		Login_Name = GUI.TextField(new Rect(xShift + 110, yShift + 120, 150, 30), Login_Name, 25);
		// Password label and password text field:
		GUI.Label(new Rect(xShift-40, yShift + 170, 100, 30), "Password:", formFieldStyle);
		Login_Password = GUI.PasswordField(new Rect(xShift + 110, yShift + 170, 150, 30), Login_Password, "*"[0], 16);
		// Login button:
		if(GUI.Button(new Rect(xShift+120, yShift + 220, 120, 30), "Enter Game")) {
			for(int m=0;m<9999;m++){
			if(Login_Name==nme[m] && Login_Password==pass[m]){
			Application.LoadLevel("Main_Menu");
			}
			}
		}
		GUI.Label(new Rect(xShift+120, yShift+255, 120, 30), "OR", header1Style);
		if(GUI.Button(new Rect(xShift+120, yShift + 290, 120, 30), "REGISTER NOW")) {
			Application.LoadLevel("Registration_Page");
		}
	
	}
	void DataBase(){
		string _strDBName = "URI=file:ENEMY_DATABASE.db";
		
		IDbConnection _connection = new SqliteConnection(_strDBName);
		
		IDbCommand _command = _connection .CreateCommand();
		
		string sql;
		
		
		
		_connection .Open();
		
		
		//****for insert data****************
		
		//sql = "INSERT INTO highscores (name, password, email, age, education, sex, d_o_e, score) VALUES ('"+Name+"', '"+Password+"', '"+Email_ID+"',"+Age+", '"+Education_Level+"', '"+Sex+"', '"+Date+"', 5000)";
		
		//_command.CommandText = sql;
		
		//_command.ExecuteNonQuery();
		
		
		
		
		
		
		sql = "select * from highscores order by score desc";
		
		_command.CommandText = sql;
		
		sql = "select * from highscores order by score desc";
		
		_command.CommandText = sql;
		
		IDataReader _reader = _command.ExecuteReader();
		int p = 0;
		
		while (_reader.Read()) {

		//Debug.Log ("****** Name: " + _reader ["name"] + "\tPassword: " + _reader ["password"]);
			 nme[p] = _reader.GetString (0);
			pass[p] = _reader.GetString (1);
			Debug.Log(nme[p]);
			Debug.Log(pass[p]);
		
			p=p+1;
				}
		_reader.Close();
		
		_reader = null;
		
		_command.Dispose();
		
		_command = null;
		
		_connection .Close();
		
		_connection = null;
		
		
		
	}
		
		
		

}


