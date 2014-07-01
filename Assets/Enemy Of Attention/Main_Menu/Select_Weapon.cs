using UnityEngine;
using System.Collections;

public class Select_Weapon : MonoBehaviour {
	   public AudioClip tick1;
	   public AudioClip tick2;
	   public AudioClip tick3;
	   public GameObject HandsUn_Ak;
	   public GameObject HandsUn_Arbalet;
	   public GameObject HandsUn_RG;
	  //public GameObject[] weapons;



	// Use this for initialization
	void Start () {
		//we want to define our first choice of weapon - this case will be the assault rifle
		HandsUn_Ak.gameObject.SetActiveRecursively(true);
		HandsUn_Arbalet.gameObject.SetActiveRecursively(false);
		HandsUn_RG.gameObject.SetActiveRecursively(false);
		//this will deactivate the pistol and frag, and leave on the assault rifle
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("1")){
			//assault key
			killAll();
			HandsUn_Ak.gameObject.SetActiveRecursively(true);
		}
		
		if(Input.GetKeyDown("2")){
			//pistol key
			killAll();
			HandsUn_RG.gameObject.SetActiveRecursively(true);
		}
		
		if(Input.GetKeyDown("3")){
			//frag key
			killAll();
			HandsUn_Arbalet.gameObject.SetActiveRecursively(true);
		}
	}
	

    void killAll(){
	HandsUn_Ak.gameObject.SetActiveRecursively(false);
	HandsUn_Arbalet.gameObject.SetActiveRecursively(false);
	HandsUn_RG.gameObject.SetActiveRecursively(false);
                   }

}
