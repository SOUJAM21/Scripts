using UnityEngine;
using System.Collections;

/// <summary>
/// Destroy the trash
/// </summary>
public class Destroy : MonoBehaviour {
	public AudioClip trash;

	/// <summary>
	/// Raises the trigger enter event.
	/// </summary>
	/// <param name="co">Object being collided with first person controller.</param>
	void OnTriggerEnter (Collider co)
	{
		//print ("ontriggerenter :" + co.tag);
		//print ("ontriggerenter gameobject:" + co.gameObject);

		// Look for trash and bottles and destroy them.
		if (co.tag.StartsWith ("Trash") || co.tag.StartsWith ("Bottle")) {
			// destroying the trash
			Destroy (co.gameObject);
			//print ("destroyed");

			// Playing the trash destrot sound
			var audio = GetComponent<AudioSource>();
			audio.PlayOneShot(trash,20);

			// Updating the score
			var scoreComponent = GetComponent<ScoreComponent> ();
			scoreComponent.ScoreChangeOnCollision();
		}
	}
}