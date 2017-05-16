﻿using UnityEngine;
using System.Collections;

public class move_test : MonoBehaviour {
	bool arrived = false;
	GameObject result = null;
	GameObject mainCamera;
	public GameObject target;
	Camera main;
	[SerializeField]
	private float speed = 1f;
	Rigidbody rb;

	// Use this for initialization
	void Start () {
		//target = GameObject.Find("targetpointA");
		rb = this.GetComponent<Rigidbody> ();
		mainCamera = GameObject.Find ("Main Camera");
	}
	
	// Update is called once per frame
	void Update () {
		main = mainCamera.GetComponent <Camera> ();
		Vector3 mousePos = main.ScreenToWorldPoint (Input.mousePosition);
		Collider2D col = Physics2D.OverlapPoint (mousePos);


			if (Input.GetMouseButtonDown (0)) {

				Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
				RaycastHit hit = new RaycastHit ();

				if (Physics.Raycast (ray, out hit)) {

					result = hit.collider.gameObject;
					this.transform.LookAt (result.transform.position);
					MoveToTarget ();	
				}


			}


	}

	void MoveToTarget () {
		if (Vector3.Distance (result.transform.position, transform.position) > 0.1f) {

			rb.velocity = transform.forward * speed;
		
		} 
		else {

			speed = 0f;

		}

	}
}
