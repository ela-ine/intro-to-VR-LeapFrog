using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frogmove : MonoBehaviour {

	public float jumpelevationdeg = 45;
	public float jumpspeedms = 5;
	public float jumpground = 20;
	public float speedlimit = 5;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		bool onground = Physics.Raycast(transform.position, -transform.up, jumpground);
		var speed = GetComponent<Rigidbody> ().velocity.magnitude;
		bool what = speed < speedlimit;
		Debug.Log ("what " + what);
		Debug.Log ("ground " + onground);

		if (Input.GetKeyDown(KeyCode.Space) && onground && what) {
			var camera = GetComponentInChildren<Camera> ();
			var projectedlookv = Vector3.ProjectOnPlane (camera.transform.forward, Vector3.up);
			var radianstorotate = Mathf.Deg2Rad * jumpelevationdeg;
			var weirdjumpv = Vector3.RotateTowards(projectedlookv, Vector3.up, radianstorotate, 0);
			var jumpvector = weirdjumpv.normalized * jumpspeedms;
			GetComponent<Rigidbody> ().AddForce (jumpvector, ForceMode.VelocityChange);
		} 
	}
}
