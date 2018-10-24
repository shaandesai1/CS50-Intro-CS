using UnityEngine;
using System.Collections;
using VRWidgets;

public class buttonquit : ButtonBase 
{
	public GameObject graphics;
	
	public override void ButtonReleased()
	{

	}
	
	public override void ButtonPressed()
	{

		Application.Quit ();
		
	}
	
	public override void Update()
	{
		base.Update();
		graphics.transform.localPosition = GetPosition();
	}
}
