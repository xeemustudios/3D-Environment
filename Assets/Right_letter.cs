using UnityEngine;
using System.Collections;

public class Right_letter : MonoBehaviour {
	void OnGUI() {
 
		Color tempColor = GUI.color;
			GUI.color = Color.green;
		 GUI.Label(new Rect(40, 10, 100, 20), "BE! CAREFULL");
        GUI.Label(new Rect(140, 10, 100, 20), "PLEASE");
		GUI.Label(new Rect(200, 10, 100, 20), "PRESS");
		GUI.Label(new Rect(250, 10, 100, 20), "THE WORDS IN");
		GUI.Label(new Rect(350, 10, 100, 20), "RIGHT ORDER");
    }
	
	
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if(Input.GetKeyUp(KeyCode.K)){
			if(Input.GetKeyUp(KeyCode.T)){
				if(Input.GetKeyUp(KeyCode.P)){
					if(Input.GetKeyUp(KeyCode.L)){
						if(Input.GetKeyUp(KeyCode.D)){
							if(Input.GetKeyUp(KeyCode.M)){
								if(Input.GetKeyUp(KeyCode.Q)){
				Debug.Log("my name is manu");
		}	
							
							}
						}
					}
				}
			}
		}
		
	}
}
