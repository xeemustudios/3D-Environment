using UnityEngine;
using System.Collections;

public class Enemy_Script : MonoBehaviour {
		
		public float AttackDistance = 18f;
		public float SeeAngle = 45f;
		public float AttackAngle = 15f;
		public float RotationSpeed = 10f;
	    public float FireDistance =7f;
		
		//public string MyWeaponNAME = "myWeapon";
		
		private NavMeshAgent agent = null;
		private Transform MyTransform = null;
		//private Weapon MyWeapon = null;
		
		private RaycastHit MyHit;
		private Ray MyRay;
		
		public GameObject Player = null;
		public bool SeePlayer = false;
		
		private Vector3 PlayerPosition;
		private Vector3 PlayerDirection;
		
		public float PlayerDistance = 0f;
		private float PlayerAngle = 0f;
		
		// Use this for initialization
		void Awake () 
		{		
			agent = GetComponent<NavMeshAgent>();
			agent.stoppingDistance = 5f;
			MyTransform = transform;
			//MyWeapon = transform.FindChild( MyWeaponNAME ).GetComponent<Weapon>();
			Player = GameObject.FindGameObjectWithTag("Player");
		}
		
		// Update is called once per frame
		void LateUpdate () 
		{   

		// agent.SetDestination(Player.transform.position );	
			PlayerPosition = Player.transform.position;
			PlayerDirection = PlayerPosition - MyTransform.position;
			PlayerDistance = Vector3.Distance( PlayerPosition, MyTransform.position );
			PlayerAngle = Vector3.Angle( PlayerDirection, MyTransform.forward );
		if (PlayerDistance > AttackDistance) {
			animation.Stop ("Walk");
			animation.Stop("StandingAim");
			animation.CrossFade("Idle",0.2f);
			
		}
			
			MyRay = new Ray( MyTransform.position, PlayerDirection.normalized );
			
			if ( Physics.Raycast( MyRay, out MyHit ) )
			{
				if ( MyHit.collider.tag =="Player" )
			{	 
					if ( PlayerDistance < AttackDistance && PlayerAngle < SeeAngle ) {

					SeePlayer = true;
				}
					else SeePlayer = false;			
				}
				else SeePlayer = false;
			}				
			
			
			if ( SeePlayer)
			{
			animation.Stop("Idle");
			animation.CrossFade("Walk",0.2f);
			agent.SetDestination( PlayerPosition );

			if ( PlayerDistance < FireDistance){
				MyTransform.rotation = Quaternion.Lerp( MyTransform.rotation, 	
				                                       Quaternion.LookRotation( PlayerPosition - MyTransform.position ), RotationSpeed * Time.deltaTime );
					
				animation.Stop("Walk");
			    animation.CrossFade("StandingAim",0.02f);

			}
				//agent.SetDestination( PlayerPosition );	
			}
			
		}
	}
