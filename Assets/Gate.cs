using UnityEngine;
using System.Collections;

public class Gate : MonoBehaviour {
	private GameObject player;
	void Awake()
	{
		player=GameObject.FindWithTag("Player");
	}
	void OnTriggerEnter(Collider other){
	if(other.gameObject==player){
			Application.LoadLevel("aa");


		}
		
		}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
