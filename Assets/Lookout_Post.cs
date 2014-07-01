using UnityEngine;
using System.Collections;

public class Lookout_Post : MonoBehaviour {

	public AudioClip player_die_sound,final_kill;
	
	private GameObject player;
	public float Health;
	public float Max_Health=100.0f;
	public float Health_Lose=10.0f;
	public float Health_Gain=5.0f;
	private float a=70.0f, b=50.0f ,c=30.0f,d=10.0f;
	
	void Awake()
	{
		player=GameObject.FindWithTag("Player");
	}
	
	void Start () {
		Health=Max_Health;
	
	
	}
	void OnTriggerEnter(Collider other){
	if(other.gameObject==player){
			if(Health >= 10.0f){
			Kill();
		               }

		}
		
		}
	
	
	void OnTriggerStay(Collider other1){
	if(other1.gameObject==player){
	Health-=Health_Lose*Time.deltaTime;
			if(Health>Max_Health){
			Health=Max_Health;
		                     }
			if(Health <= 90 || Health <= 30 ||Health <= 10){
			Kill();
		               }
			
			}
		
	}
		void OnTriggerExit(Collider other){
	if(other.gameObject!=player){
			
		audio.Stop();
		}

	}
	
	
	// Update is called once per frame
	void Update () {
	if(Health<Max_Health){
			Health+=Health_Gain*Time.deltaTime;
			
		                     }
		if(Health< 0){
			Application.LoadLevel("Lose");
			
		                     }
		
		
	}
	/*void OnGUI(){
		if(Health > a){
	    Color tempColor = GUI.color;
	   GUI.color = Color.green;
        GUI.Label(new Rect(10, 10, 100, 20), "MANU");
		GUI.color=tempColor;
		}
	if(Health<a && Health > b){
			Color tempColor = GUI.color;
			GUI.color = Color.yellow;
			GUI.Label(new Rect(10, 10, 100, 20), "MANU");
		    GUI.color=tempColor;
		}
		if(Health<b && Health > c){
			Color tempColor = GUI.color;
			GUI.color = Color.red;
			GUI.Label(new Rect(10, 10, 100, 20), "MANU");
		    GUI.color=tempColor;
		}
		if(Health<d){
			Color tempColor = GUI.color;
			GUI.color = Color.white;
			GUI.Label(new Rect(10, 10, 100, 20), "MANU");
		    GUI.color=tempColor;
		}
		
	}
	*/
	void Kill()
	{
		audio.clip=player_die_sound;
		audio.Play();
	}
	void final_Kill()
	{
		audio.clip=final_kill;
		audio.Play();
	}
	void near_to_Kill()
	{
		audio.clip=final_kill;
		audio.Play();
	}

}