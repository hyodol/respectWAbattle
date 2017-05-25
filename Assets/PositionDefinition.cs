using UnityEngine;
using System.Collections;

public class PositionDefinition : MonoBehaviour {

	public GameObject[] Positions;
	int PosNum = 1;
	string Direction = "LowerRight";
	int result;
	//int Target(int string);

	// Use this for initialization
	void Start () {
		Positions = GameObject.FindGameObjectsWithTag ("Positions");
		result = Target (PosNum, Direction);
		Debug.Log (result);
		//Debug.Log ("result is Position", Target);
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (PosNum);
	}

	public int Target (int PosNum, string Direction){
		if (Direction == "Right") {
			return 2;
		} 
		if (Direction == "LowerRight") {
			return 4;
		} 

		if (Direction == "LowerLeft") {
			return 3;
		}
		else{return 0;}
	}
}

