using UnityEngine;
using System.Collections;

public class start_login : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.name == "C_START") {
			if(Input.GetMouseButtonDown(0)){
				Application.LoadLevel("Login_Page");
			}
				}
			
		}
	void OnMouseEnter(){ 

	
		}
	void OnGUI(){
		//if(GUI.Button(new Rect(170, 190, 190, 50), "        ")) {
			//Application.LoadLevel("");
		}

		
}
