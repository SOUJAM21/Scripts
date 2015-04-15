#pragma strict
var hSliderValue : float = 0.0;
function OnGUI()
{
	hSliderValue = GUI.HorizontalSlider(Rect (25,100,100,30), hSliderValue,0.0,1.0);
	GetComponent.<AudioSource>().volume = hSliderValue;
}