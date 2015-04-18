/*

/// <summary>
/// Destroy the trash
/// </summary>

Copyright (C) 2015  Three Amigos – OGPC Team

This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation, 
either version 3 of the License, or (at your option) any later version.
This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY;
without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  
See the GNU General Public License for more details.
You should have received a copy of the GNU General Public License along with this program.  
If not, see <http://www.gnu.org/licenses/>
 */
using UnityEngine;
using System.Collections;

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