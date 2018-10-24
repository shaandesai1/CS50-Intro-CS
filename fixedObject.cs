using UnityEngine;
using System.Collections;



public class fixedObject : MonoBehaviour { 
	void OnCollisionEnter(Collision other) 
	{
		// check angle between blocks
		float angle = 90 - Mathf.Abs(Mathf.Abs(gameObject.transform.eulerAngles.y - other.transform.eulerAngles.y) - 90);
		// check if the object is a redblock
		if (other.transform.name == "Legored(Clone)" && (gameObject.transform.position.y - other.transform.position.y) > 0.4) 
		{
			// check to see if angle is greater than 50
			if (angle > 45) 
			{
				// set object on top to the rotation of the object at the bottom
				gameObject.transform.eulerAngles = other.transform.eulerAngles;
				// rotate the gameobject to 90 degrees about the y axis from the rotation of the other object
				gameObject.transform.eulerAngles = new Vector3 (gameObject.transform.eulerAngles.x, gameObject.transform.eulerAngles.y + 90, gameObject.transform.eulerAngles.z);
				// move the object to position of the other + 0.8 units up so it sits on top
				gameObject.transform.position = other.transform.position + new Vector3 (0, (float)0.8, 0);
				// create a fixed joint between the objects so they are 'sticky'
				var joint = gameObject.AddComponent<FixedJoint> ();
				joint.connectedBody = other.rigidbody;
				joint.breakForce = 10000;
				joint.breakTorque = 1000;
			} 
			else 
			{
				// same operation as above w/o 90 degree turn
				gameObject.transform.rotation = other.transform.rotation;
				gameObject.transform.position = other.transform.position + new Vector3 (0, (float)0.8, 0);
				var joint = gameObject.AddComponent<FixedJoint> ();
				joint.connectedBody = other.rigidbody;
				joint.breakForce = 10000;
				joint.breakTorque = 1000;

			}

		} 
		// see comments above
		else if (other.transform.name == "Legoblue(Clone)" && other.transform.position.y < gameObject.transform.position.y) 
		{
			if (angle > 45) 
			{
				gameObject.transform.eulerAngles = other.transform.eulerAngles;
				gameObject.transform.eulerAngles = new Vector3 (gameObject.transform.eulerAngles.x, gameObject.transform.eulerAngles.y + 90, gameObject.transform.eulerAngles.z);
				gameObject.transform.position = other.transform.position + new Vector3 (0, (float)0.6, 0);
				var joint = gameObject.AddComponent<FixedJoint> ();
				joint.connectedBody = other.rigidbody;
				joint.breakForce = 10000;
				joint.breakTorque = 1000;

			} 
			else 
			{
				gameObject.transform.rotation = other.transform.rotation;
				gameObject.transform.position = other.transform.position + new Vector3 (0, (float)0.6, 0);
				var joint = gameObject.AddComponent<FixedJoint> ();
				joint.connectedBody = other.rigidbody;
				joint.breakForce = 10000;
				joint.breakTorque = 1000;

			}
		} 
		else if (other.transform.name == "Legogreen(Clone)" && other.transform.position.y < gameObject.transform.position.y) 
		{
			if (angle > 45) 
			{
				gameObject.transform.eulerAngles = other.transform.eulerAngles;
				gameObject.transform.eulerAngles = new Vector3 (gameObject.transform.eulerAngles.x, gameObject.transform.eulerAngles.y + 90, gameObject.transform.eulerAngles.z);
				gameObject.transform.position = other.transform.position + new Vector3 (0, (float)0.8, 0);
				var joint = gameObject.AddComponent<FixedJoint> ();
				joint.connectedBody = other.rigidbody;
				joint.breakForce = 10000;
				joint.breakTorque = 1000;

			} 
			else 
			{
				gameObject.transform.rotation = other.transform.rotation;
				gameObject.transform.position = other.transform.position + new Vector3 (0, (float)0.8, 0);
				var joint = gameObject.AddComponent<FixedJoint> ();
				joint.connectedBody = other.rigidbody;
				joint.breakForce = 10000;
				joint.breakTorque = 1000;
			}
		}
	} 

}