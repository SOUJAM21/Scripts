using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {
	bool isPaused;
	string name = "Pause";
	void OnGUI()
	{

		if(GUI.Button(new Rect(680,25,100,50),name))
		   {
			if(isPaused == true)
			{
				name = "Pause";
				Time.timeScale = 1.0f;
				isPaused = false;	
			}
			else
			{
			name = "Play";
			Time.timeScale = 0.0f;
			isPaused = true;
			}
			}
			

	}
}

