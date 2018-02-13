using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//transform.Rotate(Vector3.left * Time.deltaTime * 10);
		transform.Rotate(Vector3.up * ( Time.deltaTime * 12), Space.World);
	
		
	}
}
