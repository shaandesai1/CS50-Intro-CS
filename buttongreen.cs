using UnityEngine;
using System.Collections;
using VRWidgets;

public class buttongreen : ButtonBase 
{
	// see comments on buttonblue
	public GameObject graphics;
	gamecontroller globalobj;


	public override void ButtonReleased()
	{

	}
	
	public override void ButtonPressed()
	{
		globalobj = (gamecontroller)GameObject.FindGameObjectWithTag ("global").GetComponent ("gamecontroller");
		GameObject newa = (GameObject)Instantiate (Resources.Load ("Legogreen"), new Vector3 (-1, 1, -4), Quaternion.Euler (270, 270, 0));
		globalobj.instantiatedObj.Add (newa);
	}
	
	public override void Update()
	{
		base.Update();
		graphics.transform.localPosition = GetPosition();
	}
}
