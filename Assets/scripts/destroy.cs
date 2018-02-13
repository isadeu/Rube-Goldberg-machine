using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour {

	public GameObject bowl;
	public MeshCollider bomesh;

	public Camera camera1;  //the one we jsut came from
	public Camera camera3; //camera goal
	public Camera camera2; //the one before

	/*var Camera1 Camera;
	var Camera2 Camera;*/

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
		camera3.gameObject.SetActive(true);
		camera2.enabled = false;
		camera1.enabled = false;
		camera3.enabled = true; 

	
	}
}
