using UnityEngine;
using System.Collections;

public class move_test : MonoBehaviour {
	public GameObject target;
	[SerializeField]
	private float speed = 1f;
	Rigidbody rb;

	// Use this for initialization
	void Start () {
		target = GameObject.Find("targetpointA");
		rb = this.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.LookAt (target.transform);
			MoveToTarget ();	
			}

	void MoveToTarget () {
		if (Vector3.Distance (target.transform.position, transform.position) > 0.1f) {
			rb.velocity = transform.forward * speed;
		} 
		else {
			speed = 0f;
		}

	}
}
