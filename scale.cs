using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scale : MonoBehaviour {

	int ScaleCheck = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void RotationModify(){
		if (ScaleCheck == 0) {
			this.transform.Rotate(0f, 0f, 3f);
			ScaleCheck = 1;
		} else if (ScaleCheck == 1) {
			this.transform.Rotate(0f, 0f, -3f);
			ScaleCheck = 0;
		}
	}

	public void ScaleModify(){
		if (ScaleCheck == 0) {
			this.transform.localScale = new Vector3 (0.98f, 0.98f, 1f);
			ScaleCheck = 1;
		} else if (ScaleCheck == 1) {
			this.transform.localScale = new Vector3 (1f, 1f, 1f);
			ScaleCheck = 0;
		}
	}
}
