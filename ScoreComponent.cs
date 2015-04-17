using UnityEngine;
using System.Collections;

public class ScoreComponent : MonoBehaviour {
	/// <summary>
	/// Universal script for scoring that can be used in any game
	/// </summary>

	public string gameName;
	public int Score;
	public int Max; 
	public Rect scoreRect;
	public GUISkin skin;
	public bool isUp;
	private bool isFinished;
	private int currentScore;

	void Update()
	{
		if (Score == 0) 
		{
			print("Score is 0");
			Application.LoadLevel(2);
		}
	}

	void OnGUI()
	{
		var str = string.Format ("{0}", Score);
		GUI.skin = skin;
		GUI.Label (scoreRect, str, skin.GetStyle("Timer"));
		
	}
	
	public void ScoreChangeOnCollision()
	{
		if (isUp) {       // Can be used for scores ascending or descending
			Score++;
		} else {
			Score = Score - 1;
		}
		if (Score == 0 || Score == Max) {
			isFinished = true;
		}

		currentScore++;
		var gameInfoObject = GameObject.Find("GameInfo"); 	
		var gameInfoScript = gameInfoObject.GetComponent<GameInfo>();
		if (gameName == "Beach") 
		{
			gameInfoScript.SetBeachScore(currentScore 	* 21);
		}
		else if (gameName == "SuperHero") 
		{
			gameInfoScript.SetSuperHeroScore(currentScore 	* 43);
		}
	

	}
}