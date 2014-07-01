using UnityEngine;
using System.Collections;

public class Bullet_decal : MonoBehaviour {
	
	public float LifeTime = 1.5f;
	private float ReadyTime = 0f;	
	
	public ParticleSystem prtDefaultClone=null;
	public ParticleSystem prtConcreteClone = null;
	public ParticleSystem prtWoodClone = null;
	public ParticleSystem prtMetalClone = null;
	public ParticleSystem prtGroundClone = null;
	public ParticleSystem prtBodyClone = null;	
	
	void Update () 
	{
		ReadyTime += Time.deltaTime; 
		if ( ReadyTime > LifeTime )						
		{				
			ReadyTime = 0f;
			gameObject.SetActive( false );			
		}
	}	
}
