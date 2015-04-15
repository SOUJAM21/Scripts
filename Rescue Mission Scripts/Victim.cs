using UnityEngine;
using System.Collections;
/// <summary>
/// Victim moves and collisions
/// </summary>
public class Victim : MonoBehaviour {
	public GameObject GameManager;
	public GameObject Picture;
	public GameObject Picture1;
	/// <summary>
	/// Raises the trigger enter event.
	/// </summary>
	/// <param name="co">Co.</param>
	void OnTriggerEnter(Collider co)
	{
		//victim 1
		if (co.tag == "Victim") 
		{
			Destroy(co.gameObject);
			Destroy(Picture);

		}

		//victim 2
		if (co.tag == "Victim1") 
		{
			Destroy(co.gameObject);
			Destroy(Picture1);
			
		}
	}
	
}



