using UnityEngine;
using System.Collections;

public class move_test : MonoBehaviour {

	private bool arrived;
	public GameObject target;
	[SerializeField]
	private float speed = 1f;
	Rigidbody rb;

	// Use this for initialization
	void Start () {
		target = GameObject.Find("targetpointA");
		rb = this.GetComponent<Rigidbody> ();
		arrived = false;
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.LookAt (target.transform);
		if (Vector3.Distance (target.transform.position, this.transform.position) > 1f) {
			MoveToTarget ();	

		}
			}

	void MoveToTarget () {
		rb.velocity = transform.forward * speed;
	}
}
