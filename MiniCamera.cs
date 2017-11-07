using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniCamera : MonoBehaviour {
	public GameObject MiniUI;

	// Use this for initialization
	void Start () {
		this.gameObject.GetComponent<Camera> ().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		MiniStart ();
	}

	public void MiniStart(){
		if (ObjectMaker.instance.MiniCheck == 1) {
			this.gameObject.GetComponent<Camera> ().enabled = true;
			MiniUI.gameObject.SetActive (true);
		}
	}

	public void WinMiniCameraFinish(){
		this.gameObject.GetComponent<Camera> ().enabled = false;
		MiniUI.gameObject.SetActive (false);
		ObjectMaker.instance.ItemUIOn ();
		ObjectMaker.instance.PlusTimer ();
		ObjectMaker.instance.MiniGameFinishCheck ();
		ObjectMaker.instance.RunCheck ();
	}
	public void LoseMiniCameraFinish(){
		this.gameObject.GetComponent<Camera> ().enabled = false;
		MiniUI.gameObject.SetActive (false);
		ObjectMaker.instance.ItemUIOn ();
		ObjectMaker.instance.MinusTimer ();
		ObjectMaker.instance.MiniGameFinishCheck ();
		ObjectMaker.instance.RunCheck ();
	}

}
