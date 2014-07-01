using UnityEngine;
using System.Collections;

public class START_SOUND : MonoBehaviour {
	Vector3 scale;
	Vector3 scale_a;

	// Use this for initialization
	void Start () {
		scale = transform.localScale;
		scale_a= transform.localScale;
		audio.Stop ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseEnter(){
		//if ("START".Equals (gameObject.name)) {
			audio.Play();
		scale.x = scale.x*(1.2F);
		scale.y = scale.y*(1.2F);
		transform.localScale = scale;
		scale.x = scale_a.x;
		scale.y = scale_a.y;
	}
	void OnMouseExit(){
		transform.localScale = scale_a;
		audio.Stop ();
	}
}
