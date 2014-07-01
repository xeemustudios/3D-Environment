using UnityEngine;
using System.Collections;

public class Scale_menu : MonoBehaviour {
	Vector3 scale; 


	// Use this for initialization
	void Start () {
	scale = transform.localScale;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseEnter(){
		scale.y = 5F; 
		scale.x = 5F;
		scale.z= 5F;// your new value
		transform.localScale = scale;

		}
	void OnMouseExit(){
		scale.y = 1F; // your new value
		transform.localScale = scale;
		
	}
}
