using UnityEngine;
using System.Collections;

public class NewGameButton : MonoBehaviour {
	/// <summary>
	/// Creates the button that resets the game
	/// </summary>

	public GUISkin skin;
	public Rect position = new Rect(15,15,150,150);
	
	void OnGUI()
	{
		GUI.skin = skin;
		GUI.color = Color.yellow;
		if (GUI.Button (new Rect (position), "New Game")) 
		{
			var gameInfoObject = GameObject.Find("GameInfo"); 	
			var gameInfoScript = gameInfoObject.GetComponent<GameInfo>();
			gameInfoScript.SetRescueScore(0);
			gameInfoScript.SetSuperHeroScore(0);
			gameInfoScript.SetBeachScore(0);
		}
	}
}
