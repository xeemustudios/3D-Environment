using UnityEngine;
using System.Collections;

public class Main_Menu : MonoBehaviour {
	public Texture[] pics;
	int randomNumber;
	 void Awake(){
		}

	void Start () {
		StartCoroutine (wait());
	}
	
	// Update is called once per frame
	void Update () {
		}
	void OnGUI(){

		//GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),menu_pic_1);
		//for (int i=0; i<pics.Length; i++) {
						
						
		//		}
	}


	IEnumerator wait() {
		randomNumber = Random.Range(0, 5);
		guiTexture.texture = pics [randomNumber];
		yield return new WaitForSeconds(3);
		Start ();
		}
}
