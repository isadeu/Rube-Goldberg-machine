﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followdown : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.down * 1f * Time.deltaTime);
		
	}
}
