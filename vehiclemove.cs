using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vehiclemove : MonoBehaviour {

	float velocity = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//if (){ 
		//}
		transform.Translate (velocity * Time.deltaTime, 0 , 0);
	}
}
