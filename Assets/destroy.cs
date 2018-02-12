using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour {

	public GameObject bowl;
	public MeshCollider bomesh;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay (Collider c) {


		Rigidbody rb = bowl.AddComponent(typeof(Rigidbody)) as Rigidbody;
		//FixedJoint jnt = bowl.AddComponent(typeof(FixedJoint)) as FixedJoint;  dont do this it makes evrything slow and sad
		Destroy (bomesh);
		//GameObject myGameObject = new GameObject("Test Object");
		//Rigidbody gameObjectsRigidBody = bowl.AddComponent<Rigidbody>;


	
	}
}
