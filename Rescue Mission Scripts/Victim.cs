using UnityEngine;
using System.Collections;

public class Victim : MonoBehaviour {

	public GameObject GameManager;
	public GameObject Picture;
	public GameObject Picture1;

	void OnTriggerEnter(Collider co)
	{
		if (co.tag == "Victim") 
		{
			Destroy(co.gameObject);
			Destroy(Picture);

		}

		if (co.tag == "Victim1") 
		{
			Destroy(co.gameObject);
			Destroy(Picture1);
			
		}
	}
	
}



