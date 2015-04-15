using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
	public GUISkin skin;
	public Rect ScoreRect;
	public Color notFound;
	public Color found;
	string score = "Not Found";
	bool victim1Found;

	void OnGUI()
	{
		GUI.skin = skin;
		if (victim1Found == true) {
			skin.GetStyle ("Timer").normal.textColor = found;
		} 
		if(victim1Found == false){
			skin.GetStyle ("Timer").normal.textColor = notFound;
		}
		GUI.Label (ScoreRect, score, skin.GetStyle("Timer"));

	}

	public void FlagFoundVicitm1()
	{
		victim1Found = true;
		score = "Found";
	}



}
