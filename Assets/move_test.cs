using UnityEngine;
using System.Collections;

public class move_test : MonoBehaviour {

	public GameObject target;
	[SerializeField]
	private float movement = 1f;
	[SerializeField]
	private float rotatespeed = 2f;
	float moveX = 0f, moveZ = 1f;
	Rigidbody rb;

	// Use this for initialization
	void Start () {
		target = GameObject.Find("targetpointA");
		rb = this.GetComponent<Rigidbody> ();

	}
	
	// Update is called once per frame
	void Update () {
		this.transform.LookAt (target.transform);
		movetotarget ();

	}

	IEnumerable movetotarget () {
		//while (Vector3.Distance (target.transform.position, this.transform.position) >  0.3f) {
			rb.velocity = transform.forward * 10f;
		if(Vector3.Distance (target.transform.position, this.transform.position) < 0.01f) {
			yield break;
		} 
		//}
	}
}
