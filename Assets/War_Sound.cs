using UnityEngine;
using System.Collections;

public class War_Sound : MonoBehaviour {
	public AudioClip warsound;
		private GameObject player;
	void Awake()
	{
		player=GameObject.FindWithTag("Player");
	}
	// Use this for initialization
	void Start () {
	
	}
	void OnTriggerEnter(Collider other){
	if(other.gameObject==player){
			audio.clip=warsound;
		audio.Play();

		}
	}
	void OnTriggerExit(Collider other){
	if(other.gameObject!=player){
			
		audio.Stop();
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
