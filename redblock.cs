using UnityEngine;
using System.Collections;
using VRWidgets;

public class redblock : ButtonBase 
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
		GameObject newa = (GameObject)Instantiate (Resources.Load ("Legored"), new Vector3 (1, 1, -5), Quaternion.Euler (270, 270, 0));
		globalobj.instantiatedObj.Add (newa);

	}
	
	public override void Update()
	{
		base.Update();
		graphics.transform.localPosition = GetPosition();
	}
}
