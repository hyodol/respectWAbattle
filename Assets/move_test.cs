﻿using UnityEngine;
using System.Collections;

public class move_test : MonoBehaviour {
	private bool moving; 
	GameObject result = null;
	GameObject mainCamera;
	public GameObject target;
	Camera main;
	[SerializeField]
	private float speed = 10f;
	Rigidbody rb;

	// Use this for initialization
	void Start () {
		//target = GameObject.Find("targetpointA");
		rb = this.GetComponent<Rigidbody> ();
		mainCamera = GameObject.Find ("Main Camera");
		moving = false;
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
                Debug.Log("click");
                result = hit.collider.gameObject;
				this.transform.LookAt (result.transform.position);
				rb.velocity = transform.forward * speed;
				moving = true;
					}
		}
		if (moving) {
			if (Vector3.Distance (result.transform.position, this.transform.position) < 0.1f) {
				rb.velocity = new Vector3 (0, 0, 0);
				moving = false;
                Debug.Log("moving");
            } 
		}


	}


}
