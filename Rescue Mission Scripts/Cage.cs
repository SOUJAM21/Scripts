using UnityEngine;
using System.Collections;
public class Cage : MonoBehaviour {
	public AudioClip unlock;
	public GameObject deathparticles;

	void OnTriggerEnter(Collider co1)
	{
		if (co1.gameObject.tag == "Cage") 
		{
			var audio = GetComponent<AudioSource> ();
			audio.PlayOneShot (unlock);
			Destroy (co1.gameObject);
			Instantiate(deathparticles,transform.position,transform.rotation);
		}
		if (co1.gameObject.tag == "Cage1") 
		{
			var audio = GetComponent<AudioSource> ();
			audio.PlayOneShot (unlock);
			Destroy (co1.gameObject);
			Instantiate(deathparticles,transform.position,transform.rotation);
		}

	}
}