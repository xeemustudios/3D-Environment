using UnityEngine;
using System.Collections;

public class tst : MonoBehaviour {

    void OnGUI() {
 
		Color tempColor = GUI.color;
			GUI.color = Color.green;
        GUI.Label(new Rect(10, 10, 100, 20), "MANU");
		GUI.color=tempColor;
    }
	void Update(){
		if(Input.GetKeyUp(KeyCode.D)){
			
		Application.LoadLevel("Win");
		}
	
	if(Input.GetKeyUp(KeyCode.K)){
			
	
			 Application.LoadLevel("Lose");
		}
		if(Input.GetKeyUp(KeyCode.T)){
			
	
			 Application.LoadLevel("Lose");
		}
		if(Input.GetKeyUp(KeyCode.P)){
			
	
			 Application.LoadLevel("Lose");
		}
		if(Input.GetKeyUp(KeyCode.L)){
			
	
			 Application.LoadLevel("Lose");
	
		}
		if(Input.GetKeyUp(KeyCode.M)){
			
	
			 Application.LoadLevel("Lose");
		}
		if(Input.GetKeyUp(KeyCode.Q)){
			
	
			 Application.LoadLevel("Lose");
		}
	}
	
}
