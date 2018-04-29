using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vehiclespawn : MonoBehaviour {

	public GameObject prefab;

	public float spawnIntMin = 2;
	public float spawnIntMax = 6;
	float nextSpawnTime = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > nextSpawnTime) {
			spawn ();
			nextSpawnTime = Time.time + Random.Range (spawnIntMin, spawnIntMax);
		}
	}

	void spawn() {
		var instance = Instantiate (prefab, transform.position, transform.rotation, transform);
	}

}
