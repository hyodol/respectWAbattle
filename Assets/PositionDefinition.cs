﻿using UnityEngine;
using System.Collections;

public class PositionDefinition : MonoBehaviour {

	public GameObject[] Positions;
	int PosNum = 1;
	string Direction = "Right";
	int result;
	int Target(int, string);

	// Use this for initialization
	void Start () {
		Positions = GameObject.FindGameObjectsWithTag ("Positions");
	}
	
	// Update is called once per frame
	void Update () {
		result = Target (PosNum, Direction);
		Debug.Log ("result is Position", Target);
	}
}

int Target (int PosNum, string Direction){
	if(Direction == Right){
		return PosNum = PosNum + 1;
	}
}