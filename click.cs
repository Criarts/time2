using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click : MonoBehaviour {

	public int Count = 0;
	public int StageCheck = 0;
	public int MaxClick = 30;
	public GameObject bossdie;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Click(){

		Count += 1;

		if (Count < MaxClick) {
			if (StageCheck == 0)
				GameObject.Find ("BellScale").GetComponent<scale> ().RotationModify ();
			else if (StageCheck == 1)
				GameObject.Find ("DoorScale").GetComponent<scale> ().ScaleModify ();
			else if (StageCheck == 2) {
				GameObject.Find ("Agent").GetComponent<scale> ().ScaleModify ();
			}
		}
		else if (Count == MaxClick) {
			if (StageCheck == 0) {
				GameObject.Find ("Bell").SetActive (false);
				GameObject.Find ("Main Camera").GetComponent<BossCamera1> ().MoveNumber = 1;
				StageCheck = 1;
				MaxClick = 50;
				Count = 0;
				GameObject.Find ("Time").GetComponent<time> ().timecheck = 50;
			} else if (StageCheck == 1) {
				GameObject.Find ("Door").SetActive (false);
				GameObject.Find ("Main Camera").GetComponent<BossCamera1> ().MoveNumber = 2;
				StageCheck = 2;	
				MaxClick = 70;
				Count = 0;
				GameObject.Find ("Time").GetComponent<time> ().timecheck = 70;
			} else if (StageCheck == 2) {
				GameObject.Find ("BossStand").SetActive (false);
				bossdie.gameObject.SetActive (true);
			}
		}
	}
}
