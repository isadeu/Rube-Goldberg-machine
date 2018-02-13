using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camchange : MonoBehaviour {


	public Camera cameraorigin;
	public Camera cameragoal;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		
	}

	void OnTriggerStay (Collider c) {
		cameragoal.gameObject.SetActive(true);
		cameraorigin.enabled = false;
		cameragoal.enabled = true; 
	}
}
