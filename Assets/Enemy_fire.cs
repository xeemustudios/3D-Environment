using UnityEngine;
using System.Collections;

public class Enemy_fire : MonoBehaviour {
	Animation anim;
	public GameObject enemy;

	LineRenderer line;
	public GameObject hit_mark;
	public GameObject blood_particals;
	
	// Use this for initialization
	void Start () {
		line = gameObject.GetComponent<LineRenderer> ();
		//anim = GameObject.GetComponent<Animation> ();
		line.enabled = false;

	}
	
	// Update is called once per frame
	void Update(){
		//if(anim.IsPlaying("StandingAim")){IEnumerator GunFire(){
		line.enabled = true;
		//while (Input.GetButton("Fire1")) {
		//Instantiate(Gun_tip_smoke,transform.position,Quaternion.identity);
		Ray ray = new Ray (transform.position, transform.forward);
		RaycastHit hit;
		line.SetPosition (0, ray.origin);
		if (Physics.Raycast (ray, out hit, 100)) {

			line.SetPosition (1, hit.point);
	
			if (hit.rigidbody) {
				Debug.Log("manu");
				Instantiate(hit_mark,hit.point,Quaternion.identity);
				Instantiate(blood_particals,hit.point,Quaternion.identity);
				hit.rigidbody.AddForceAtPosition (transform.forward * 5, hit.point);
				
			}
			//    }
			else
				line.SetPosition (1, ray.GetPoint (100));
		}
		line.enabled = false;
		
	}
	}

		
		

