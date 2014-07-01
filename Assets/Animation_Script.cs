using UnityEngine;
using System.Collections;

public class Animation_Script : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Screen.lockCursor = true;
		animation.wrapMode = WrapMode.Loop;
		animation["Reload"].wrapMode = WrapMode.Once;
		animation["Dropout"].wrapMode = WrapMode.Once;
		animation["Dropin"].wrapMode = WrapMode.Once;
		animation["Shot"].wrapMode = WrapMode.Once;
		//animation.CrossFade("Reload", 0.8f);
		animation["Reload"].layer = 1;
		animation["Dropout"].layer = 2;
		animation["Dropin"].layer = 2;
		animation["Shot"].layer = 3;
		animation.Stop ();
	
	}
	
	// Update is called once per frame
	void Update () {
		//StartCoroutine(DoAnimation()); 
		DoAnimation ();
		if (Input.GetButtonDown ("Fire1")) {

						Shot ();
				}
	
	}


  void DoAnimation() {
		if (Mathf.Abs (Input.GetAxis ("Vertical")) > 0.1)
						animation.CrossFade ("Walk", 0.2f);
			else
				animation.CrossFade("Stand",0.2f);
		                                                  
		if (Input.GetKey (KeyCode.R))
						animation.CrossFade("Reload",0.2f);		
	   else if (Input.GetKey(KeyCode.G))
			animation.CrossFade("Dropout",0.2f);
		else if (Input.GetKey(KeyCode.E))
			animation.CrossFade("Dropin",0.2f);


	}
	void Shot(){
		//if(Input.GetKey(KeyCode.Mouse0))
			animation.CrossFade("Shot",0.02f);


		}
}