using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trees : MonoBehaviour {

	public GameObject treePrefab;
	public int mintree = 2;
	public int maxtree = 5;

	// Use this for initialization
	void Start () {
		int treenumber = Random.Range (mintree, maxtree);
		for (int currentree = 0; currentree < treenumber; currentree++) {
			spawntree ();
		}
	}

	void spawntree(){

		var tree = Instantiate (treePrefab);
		tree.transform.parent = transform;
		tree.transform.localPosition = new Vector3(Random.Range(-40, 40), 0, Random.Range(-5, 5));

	}

	// Update is called once per frame
	void Update () {
		
	}
}
