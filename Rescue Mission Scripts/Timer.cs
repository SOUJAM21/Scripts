/*
/// <summary>
/// Timer creation and running
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

public class Timer : MonoBehaviour {
	public float Minutes;
	private float seconds = 0;
	private string currentTime;

	public Rect timerRect;
	public GUISkin skin;

	public Color normalColor;
	public Color warningColor;
	
	/// <summary>
	/// Method of subtracting time
	/// </summary>
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
	/// <summary>
	/// Creates the timer through GUI
	/// </summary>
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
