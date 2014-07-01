using UnityEngine;
using System.Collections;

public class Startswitch : MonoBehaviour {
	public float myTimer=24.0f;
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(myTimer>0){
			myTimer-=Time.deltaTime;
		}
	if(myTimer<0){
			Application.LoadLevel("simpleaibehaviors 1");
		}
	
	}
}
