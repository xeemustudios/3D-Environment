using UnityEngine;
using System.Collections;

public class Nav_Mesh : MonoBehaviour {
	public GameObject target;
	//int ran_num=0;
	//public GameObject[] Check_Points;
	NavMeshAgent agent;

	// Use this for initialization
	void Start () {
	//	currentposition = transform.localPosition;
		agent = GetComponent<NavMeshAgent> ();
		//ran_num = Random.Range (0,2);
		//if (ran_num == 2) {
					//	ran_num = 0;
				//}
		//Debug.Log (ran_num);
		//StartCoroutine("reach_point");
	}
	
	// Update is called once per frame
	void Update () {
		agent.SetDestination(target.transform.position);

			animation.CrossFade("StandingAim",0.02f);
				
	
	}

	//IEnumerator reach_point(){

		//agent.SetDestination(Check_Points[ran_num].transform.localPosition);
		//ran_num++;
		//yield return new WaitForSeconds (6);
		//Start ();

	//	}
}
