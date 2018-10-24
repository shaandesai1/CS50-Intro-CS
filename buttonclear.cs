using UnityEngine;
using System.Collections;
using VRWidgets;

public class buttonclear : ButtonBase 
{
	public GameObject graphics;
	gamecontroller globalobj;
	public override void ButtonReleased()
	{
		
	}
	
	public override void ButtonPressed()
	{
		// access global array and delete each object
		globalobj = (gamecontroller)GameObject.FindGameObjectWithTag ("global").GetComponent ("gamecontroller");
		for (int i = 0; i < globalobj.instantiatedObj.Capacity; i++) 
		{
			Destroy (globalobj.instantiatedObj [i]);
		}
	}
	
	public override void Update()
	{
		base.Update();
		graphics.transform.localPosition = GetPosition();
	}
}
