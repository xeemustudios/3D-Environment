using UnityEngine;
using System.Collections;

public class RG_blaast : MonoBehaviour {
	LineRenderer line;
	public GameObject hit_mark;
	public GameObject Gun_tip_smoke;
	public GameObject hit_point_smoke;
	public GameObject blood_particals;
	public float radius;
	
	
	// Use this for initialization
	void Start () {
		Debug.Log("manu1");
		line = gameObject.GetComponent<LineRenderer> ();
		line.enabled = false;
		//Screen.lockCursor = true;
		Debug.Log("manu1");
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetButtonDown ("Fire1")) {
			audio.Play(); 
			//StartCoroutine("wait");
			Debug.Log("manu1");
			StopCoroutine("GunFire");
			StartCoroutine("GunFire");
			
			
			
		}
	}
	IEnumerator GunFire(){
		line.enabled = true;
		//while (Input.GetButton("Fire1")) {
		Instantiate(Gun_tip_smoke,transform.position,Quaternion.identity);
		Ray ray = new Ray (transform.position, transform.forward);
		RaycastHit hit;
		line.SetPosition (0, ray.origin);
		if (Physics.Raycast (ray, out hit, 100)) {
			Debug.Log("manu");
			line.SetPosition (1, hit.point);
			if (hit.rigidbody==null) {
				Instantiate(hit_mark,hit.point,Quaternion.identity);
				Instantiate(hit_point_smoke,hit.point,Quaternion.identity);
			                   }
			if (hit.rigidbody) {
				//Instantiate(hit_mark,hit.point,Quaternion.identity);
				Instantiate(blood_particals,hit.point,Quaternion.identity);

				
			                   }
			Collider[] colliders =Physics.OverlapSphere(hit.point,radius);
			foreach(Collider c in colliders){
				if(c.rigidbody==null) continue;
				c.rigidbody.AddExplosionForce(100.0f, hit.point,radius,0.5f,ForceMode.Impulse);



			}
		                                          }
			else
				line.SetPosition (1, ray.GetPoint (100));
			yield return null;
		//}
		line.enabled = false;
		
	}
	
	
}
