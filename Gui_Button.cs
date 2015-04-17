using UnityEngine;
using System.Collections;

public class Gui_Button : MonoBehaviour
{
	/// <summary>
	/// This creates the image used in Main Menu
	/// </summary>
	public Texture2D buttonImage;
	public Rect position = new Rect(15,15,150,150);
	public string title;
	public int NextLevel =1;
	public void OnGUI()
	{
		var style = new GUIStyle ();
		style.fontSize = 50;
		GUI.Label (position, new GUIContent (title), style);
		var buttonPosition = new Rect (position.x, position.y + 50, position.width, position.height);
		if( GUI.Button(buttonPosition, buttonImage) )
		{
			Application.LoadLevel(NextLevel);
		}
	} 
}