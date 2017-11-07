using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossCamera1 : MonoBehaviour {

	public float speed=15f;
	public int MoveNumber = 0;
	Vector3 velocity;




	// Use this for initialization
	void Start () {
		velocity = Vector3.zero;
	}

	// Update is called once per frame
	void Update () {
		if (MoveNumber == 1) {
			FirstCameraMove ();
		}
		else if(MoveNumber==2){
			SecondCameraMove();
		}

	}

	public void FirstCameraMove(){
		float step = speed * Time.deltaTime;
		this.transform.position = Vector3.SmoothDamp(this.transform.position, new Vector3(15f, 1f, -10f),ref velocity,1f);
	}
	public void SecondCameraMove(){
		float step = speed * Time.deltaTime;
		this.transform.position = Vector3.SmoothDamp (this.transform.position, new Vector3 (31.5f, 1f, -10f),ref velocity,1f);
	}
}
