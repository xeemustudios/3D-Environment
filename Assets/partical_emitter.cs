using UnityEngine;
using System.Collections;

public class partical_emitter : MonoBehaviour {

	public ParticleEmitter part1,part2,part3,part4,part5;

	
	void Awake()
	{
	}
	
	void Start () {
	
	
	}
	
	
	// Update is called once per frame
	void Update () {
		ParticleEmitter pe1=(ParticleEmitter)Instantiate(part1,transform.position,Quaternion.identity);
		ParticleEmitter pe2=(ParticleEmitter)Instantiate(part2,transform.position,Quaternion.identity);
		ParticleEmitter pe3=(ParticleEmitter)Instantiate(part3,transform.position,Quaternion.identity);
		ParticleEmitter pe4=(ParticleEmitter)Instantiate(part4,transform.position,Quaternion.identity);
		ParticleEmitter pe5=(ParticleEmitter)Instantiate(part5,transform.position,Quaternion.identity);
		pe1.Emit();
		pe2.Emit();
		pe3.Emit();
		pe4.Emit();
		pe5.Emit();
		
	
	}
}
