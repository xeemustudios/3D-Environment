using UnityEngine;
using System.Collections;

public class AK_GunBullet : MonoBehaviour {
	LineRenderer line;
	public GameObject hit_mark;
	public GameObject Gun_tip_smoke;
	public GameObject hit_point_smoke;
	public GameObject blood_particals;

	int cursorSizeX = 32;
	int cursorSizeY = 32;
	public Texture2D originalCursor;
	static bool showOriginal= true;


	// Use this for initialization
	void Start () {
		Screen.showCursor = false;
		Debug.Log("manu1");
		line = gameObject.GetComponent<LineRenderer> ();
		line.enabled = false;
		Screen.lockCursor = true;
		Debug.Log("manu1");
	
	}
	
	// Update is called once per frame
	void Update () {
		  
		//transform.LookAt(Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));

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
				 Instantiate(hit_mark,hit.point,Quaternion.identity);
				Instantiate(blood_particals,hit.point,Quaternion.identity);
				hit.rigidbody.AddForceAtPosition (transform.forward * 5, hit.point);
					         
				}
						                                     //    }
			              else
								line.SetPosition (1, ray.GetPoint (100));
						        yield return null;
				                                                   }
		                line.enabled = false;

				                        }
	void OnGUI(){
		
		if(showOriginal == true){
			GUI.DrawTexture (new Rect(Input.mousePosition.x-cursorSizeX/2 + cursorSizeX/2, (Screen.height-Input.mousePosition.y)-((cursorSizeY/2)) + cursorSizeY/2, cursorSizeX, cursorSizeY),originalCursor);
			//GUI.DrawTexture (Rect(Event.current.mousePosition.x-cursorSizeX/2, Event.current.mousePosition.y-cursorSizeY/2, cursorSizeX, cursorSizeY),originalCursor);
			//GUI.DrawTexture(Rect(Input.mousePosition.x, Input.mousePosition.y, originalCursor.width, originalCursor.height), originalCursor); 
		}
		
		
	}
			
}
