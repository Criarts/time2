//최종 수정자:김영민
//수정날짜: 2017/09/24
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour {

	public int BaseSpeed = 16;
	int Speed;


	// Use this for initialization
	void Start () {
		Speed = BaseSpeed;
	}
	
	// Update is called once per frame
	void Update () {
		RunPlyer ();
	}

	void RunPlyer(){
		if (ObjectMaker.instance.StopCheck == 0) {
			transform.Translate (Vector3.forward * Speed * Time.deltaTime);
		}
}
	public int itemupspeed(int item_speed){
		Speed = BaseSpeed+item_speed;
		return Speed;
	}

}