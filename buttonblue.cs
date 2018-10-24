using UnityEngine;
using System.Collections;
using VRWidgets;

public class buttonblue : ButtonBase 
{
	// create a graphics var
	public GameObject graphics;
	// access a global array
	gamecontroller globalobj;

	public override void ButtonReleased()
	{
	}
	
	public override void ButtonPressed()
	{
		// find the global array
		globalobj = (gamecontroller)GameObject.FindGameObjectWithTag ("global").GetComponent ("gamecontroller");
		// create a new block, and save it as a gameobject var
		GameObject newa = (GameObject)Instantiate (Resources.Load ("Legoblue"), new Vector3 (2, 1, -3), Quaternion.Euler (270, 270, 0));
		// append newa to the array
		globalobj.instantiatedObj.Add (newa);

	}
	
	public override void Update()
	{
		// update the hands position
		base.Update();
		graphics.transform.localPosition = GetPosition();
	}
}
