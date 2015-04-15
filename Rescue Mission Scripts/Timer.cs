using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {
	public float Minutes;
	private float seconds = 0;
	private string currentTime;

	public Rect timerRect;
	public GUISkin skin;

	public Color normalColor;
	public Color warningColor;


	void Update()
	{
		if (seconds <= 0) {
			Minutes--;
			seconds = 59;
		}
		seconds -= Time.deltaTime;
		currentTime = string.Format("{0:0}:{1:00}",Minutes,seconds);
		if (Minutes <= 0) 
		{
			if(seconds <= 0)
			{
			Minutes = 0f;
			seconds = 0f;
			}
		}
		if (seconds == 0) 
		{
			Application.LoadLevel(4);
		}
		if (Input.GetKeyDown (KeyCode.Escape))
		{
			Application.LoadLevel(0);
		}

	}
	void OnGUI()
	{
		GUI.skin = skin;

		if (Minutes < 1f) 
		{
			skin.GetStyle ("Timer").normal.textColor = warningColor;
		}
		else
		{
			
			skin.GetStyle("Timer").normal.textColor = normalColor;
		}
		GUI.Label (timerRect, currentTime, skin.GetStyle("Timer"));
	}
}
