using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	private Rigidbody r;

	// Use this for initialization
	void Start () {
		r = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			r.AddRelativeForce(Vector3.right * Random.Range(-20f,20f) + Vector3.forward * 2000);
		}

		if (Input.GetKeyDown (KeyCode.A)) 
		{
			transform.position += new Vector3(-0.1f,0,0);
		}

		if (Input.GetKeyDown (KeyCode.D)) 
		{
			transform.position += new Vector3(0.1f,0,0);
		}

		if (Input.GetKeyDown (KeyCode.LeftArrow)) 
		{
			r.AddTorque (Vector3.up);
		}

		if (Input.GetKeyDown (KeyCode.RightArrow)) 
		{
			r.AddTorque (Vector3.down);
		}

		if (Input.GetKeyDown (KeyCode.RightArrow)) 
		{
			r.AddTorque (Vector3.down);
		}

		if (Input.GetKeyDown (KeyCode.R)) 
		{
			r.position = new Vector3 (0, 0, 0);
			r.transform.forward = new Vector3 (0, 0, 0);
			r.velocity = Vector3.zero;
			r.angularVelocity = Vector3.zero;
		}
	}
}
