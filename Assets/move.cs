using UnityEngine;
using System.Collections;



public class move : MonoBehaviour {

	GameObject result = null;
	GameObject mainCamera;
	GameObject targetpointA;
	Camera main;
	public float speed = 5;
	public GameObject target;

	void Start (){
		mainCamera = GameObject.Find ("Main Camera");
	}

	// Update is called once per frame
	void Update () {

		main = mainCamera.GetComponent <Camera> ();
		Vector3 mousePos = main.ScreenToWorldPoint (Input.mousePosition);
		Collider2D col = Physics2D.OverlapPoint (mousePos);

		if (Input.GetMouseButtonDown (0))
		{
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit = new RaycastHit ();
			if (Physics.Raycast (ray, out hit))
			{

				result = hit.collider.gameObject;
					
				//target = result;

				//targetの座標を取得
				Vector3 targetposition = result.transform.position;

				//targetの方を向ける
				transform.LookAt(targetposition);

				while(Vector3.Distance(targetposition, transform.position) > 0.3f)
				{
					this.transform.position += new Vector3 (1, 0, 0);

					continue;
				
				}
			}
		}


			
	}
}
