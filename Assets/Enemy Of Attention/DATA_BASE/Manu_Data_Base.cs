using UnityEngine;
using System;
using System.Collections;
// For SQLite
using System.Data;
using Mono.Data.SqliteClient;
public class Manu_Data_Base : MonoBehaviour {

	// Use this for initialization
	void Start () {
		string _strDBName = "URI=file:ENEMY_DATABASE.db";
		
		IDbConnection _connection = new SqliteConnection(_strDBName);
		
		IDbCommand _command = _connection .CreateCommand();
		
		string sql;
		
		
		
		_connection .Open();
		
		
		
		sql = "CREATE TABLE highscores (name VARCHAR(20), password VARCHAR(20), email VARCHAR(20), age INT, education VARCHAR(40), sex VARCHAR(10), d_o_e VARCHAR(20), score INT)";
		
		_command.CommandText = sql;
		
		_command.ExecuteNonQuery();
		
		
		
		sql = "INSERT INTO highscores (name, password, email, age, education, sex, d_o_e, score) VALUES ('Manu', 'manu1234', 'manugupta1919@gmail.com', 25, 'MCA', 'male', '10-03-2014', 5000)";
		
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
	
	// Update is called once per frame
	void Update () {
	
	}
}
