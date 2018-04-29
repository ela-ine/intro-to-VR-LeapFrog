using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lanes : MonoBehaviour {

	public GameObject[] lanePrefab;


	// Use this for initialization
	void Start () {
		int offset = 0;
		while (offset < 500) {
			create (offset);
			offset += 10;
		}
	}


	void create(float offset) {
		int index = Random.Range(0, lanePrefab.Length);
		var lane = Instantiate (lanePrefab[index]); 
		lane.transform.parent = transform;
		lane.transform.Translate (0, 0, offset);
	}

	// Update is called once per frame
	void Update () {
		//if(Input.GetButtonDown("Fire1") {
			
		//}
	}
}
