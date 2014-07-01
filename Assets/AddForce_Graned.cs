using UnityEngine;
using System.Collections;

public class AddForce_Graned : MonoBehaviour {
	//float force 10.0f;

	// Use this for initialization
	void Start () {
		rigidbody.AddForceAtPosition(transform.localPosition,transform.forward,ForceMode.Impulse);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
