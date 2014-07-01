using UnityEngine;
using System.Collections;

public class Look_Out_Explosion : MonoBehaviour {
	
    private Light mylight;
	private Renderer myrenderer;
	
	private GameObject k;
	private GameObject t;
	private GameObject p;
	private GameObject l;
	private GameObject d;
	private GameObject m;
	private GameObject q;
	
	private GameObject lookout_post;
	private GameObject lookout_post2;
	private GameObject lookout_post3;
	private GameObject lookout_post4;
	private GameObject lookout_post5;
	private GameObject lookout_post6;
	private GameObject lookout_post7;
	private GameObject wood;
	
	public AudioClip Bomb_sound;
	public AudioClip K_sound;
	
	
	
	void Awake()
	{
		k=GameObject.FindWithTag("K");
		t=GameObject.FindWithTag("T");
		p=GameObject.FindWithTag("P");
		l=GameObject.FindWithTag("L");
		d=GameObject.FindWithTag("D");
		m=GameObject.FindWithTag("M");
		q=GameObject.FindWithTag("Q");
		
		lookout_post=GameObject.FindWithTag("LookOut_Post");
		lookout_post2=GameObject.FindWithTag("LookOut_Post2");
		lookout_post3=GameObject.FindWithTag("LookOut_Post3");
		lookout_post4=GameObject.FindWithTag("LookOut_Post4");
		lookout_post5=GameObject.FindWithTag("LookOut_Post5");
		lookout_post6=GameObject.FindWithTag("LookOut_Post6");
		lookout_post7=GameObject.FindWithTag("LookOut_Post7");
		
		//wood=GameObject.FindWithTag("");
	}
	
	void Start () {
		
	
	
	}
	void OnCollisionEnter(Collision other){
		if(other.gameObject.tag=="wood"){
		audio.clip=Bomb_sound;
		audio.Play();
			
	  mylight = other.gameObject.GetComponent<Light>();
			mylight.enabled=!mylight.enabled;
		}
		
		
	}
			
		void OnTriggerEnter(Collider other){
		if(other.gameObject==q){
			audio.clip=K_sound;
		    audio.Play();
			myrenderer = other.gameObject.GetComponent<Renderer>();
			myrenderer.enabled=true;
			Destroy (other.gameObject,3.0f);
			
	   	}
		if(other.gameObject==m){
			audio.clip=K_sound;
		    audio.Play();
			myrenderer = other.gameObject.GetComponent<Renderer>();
			myrenderer.enabled=true;
			Destroy (other.gameObject,3.0f);
			
	   	}
		if(other.gameObject==d){
			audio.clip=K_sound;
		    audio.Play();
			myrenderer = other.gameObject.GetComponent<Renderer>();
			myrenderer.enabled=true;
			Destroy (other.gameObject,3.0f);
			
	   	}
		if(other.gameObject==l){
			audio.clip=K_sound;
		    audio.Play();
			myrenderer = other.gameObject.GetComponent<Renderer>();
			myrenderer.enabled=true;
			Destroy (other.gameObject,3.0f);
			
	   	}
		if(other.gameObject==t){
			audio.clip=K_sound;
		    audio.Play();
			myrenderer = other.gameObject.GetComponent<Renderer>();
			myrenderer.enabled=true;
			Destroy (other.gameObject,3.0f);
			
	   	}	if(other.gameObject==p){
			audio.clip=K_sound;
		    audio.Play();
			myrenderer = other.gameObject.GetComponent<Renderer>();
			myrenderer.enabled=true;
			Destroy (other.gameObject,3.0f);
			
	   	}	
		
		if(other.gameObject==k){
			audio.clip=K_sound;
		    audio.Play();
			myrenderer = other.gameObject.GetComponent<Renderer>();
			myrenderer.enabled=true;
			Destroy (other.gameObject,3.0f);
			
	   	}	
		
			
		if(other.gameObject==lookout_post){
			myrenderer = other.gameObject.GetComponent<Renderer>();
			myrenderer.enabled=true;
			Destroy (other.gameObject,2.0f);
			
	   	}	
	   	if(other.gameObject==lookout_post2){
			myrenderer = other.gameObject.GetComponent<Renderer>();
			myrenderer.enabled=true;
			Destroy (other.gameObject,2.0f);
			
	   	}
		if(other.gameObject==lookout_post3){
			myrenderer = other.gameObject.GetComponent<Renderer>();
			myrenderer.enabled=true;
			Destroy (other.gameObject,2.0f);
			
	   	}
		if(other.gameObject==lookout_post4){
			myrenderer = other.gameObject.GetComponent<Renderer>();
			myrenderer.enabled=true;
			Destroy (other.gameObject,2.0f);
			
	   	}
		if(other.gameObject==lookout_post5){
			myrenderer = other.gameObject.GetComponent<Renderer>();
			myrenderer.enabled=true;
			Destroy (other.gameObject,2.0f);
			
	   	}
		if(other.gameObject==lookout_post6){
			myrenderer = other.gameObject.GetComponent<Renderer>();
			myrenderer.enabled=true;
			Destroy (other.gameObject,2.0f);
			
	   	}
		if(other.gameObject==lookout_post7){
			myrenderer = other.gameObject.GetComponent<Renderer>();
			myrenderer.enabled=true;
			Destroy (other.gameObject,2.0f);
			
	   	}
		
	}
		
	
		void Update () {
	}
		
}
