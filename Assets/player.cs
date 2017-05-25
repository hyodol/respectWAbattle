using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

	//自分が所属するHEXの番号
	public int positionNum;
	//positionNumに対応したHEXを格納
	GameObject position;
	//注視するHEXを格納
	GameObject LookTarget;
	//モーション用に移動中か否か判断するため
	public bool moving; 
	//移動スピードを設定
	[SerializeField]
	private float speed = 10f;

	// Use this for initialization
	void Start () {
		//初期位置と向きを決める。そのうちランダムにする
		int var;
		var = Random.Range (1, 7);
		positionNum = var;
		position = GameObject.Find ("Position" + positionNum);
		LookTarget = GameObject.Find ("Position4");
		this.transform.position = position.transform.position;
		this.transform.LookAt (LookTarget.transform.position);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
