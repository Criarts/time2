//최종 수정자:김영민
//수정날짜: 2017/09/24
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	int MiniRandom;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void RightMove(){
		if (ObjectMaker.instance.StopCheck == 0) {
			if (this.gameObject.transform.position.x >= 1.5) {
				this.gameObject.transform.Translate (0, 0, 0);
			} else {
				this.gameObject.transform.Translate (1.5f, 0, 0);
			}
		}
	}

	public void LeftMove(){
		if(ObjectMaker.instance.StopCheck==0){
		if (this.gameObject.transform.position.x<=-1.5) {
			this.gameObject.transform.Translate(0,0,0);
		}
		else {
			this.gameObject.transform.Translate(-1.5f,0,0);
		}
		}
	}

	void OnCollisionEnter(Collision Col){
		MiniRandom = Random.Range (0, 10);
		if (Col.gameObject.tag == "Enemy") {
			if (MiniRandom >= 3) {
				ObjectMaker.instance.MiniGameCheck ();
				GameObject.Find ("GameManager").GetComponent<PlayerHealth> ().Reset ();
				GameObject.Find ("Item").SetActive (false);
			} else {
				ObjectMaker.instance.PlusTimer ();
			}
			Col.gameObject.SetActive (false);
		}
	}
}
