using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIchanger : MonoBehaviour {

	GameObject timereaper;
	GameObject mainbutton;

	// Use this for initialization
	void Start () {
		timereaper = GameObject.Find ("TimeReaper");
		mainbutton = GameObject.Find ("MainButton");
		mainbutton.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void UIoN(){
		timereaper.gameObject.SetActive (false);
		mainbutton.gameObject.SetActive (true);
	}
}
