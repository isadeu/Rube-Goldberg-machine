using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour {


	//public float movspeed = 0;
	// Use this for initialization
	void Start () {
		print(Screen.currentResolution);
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.Translate (Vector3.right * 2f * Time.deltaTime);
		
		
	}

}
