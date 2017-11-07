using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class time : MonoBehaviour {
	
	public int timecheck = 30;
	public Text tx_Boss;
	public int StopCheck = 0;
	public int StopTime = 0;
	public float TimeSpeed = 1f;
	public int BossStartCheck=0;

	// Use this for initialization

	IEnumerator Timer_Boss(){
		while (true) {
			yield return new WaitForSeconds (TimeSpeed);
			if (StopTime == 0) {
				timecheck--;
				tx_Boss.text = timecheck.ToString ();
				}	
		}
	}

	void Start () {
		StartCoroutine (Timer_Boss ());
	}
	
	// Update is called once per frame
	void Update () {
		if (timecheck == 0) {
			StopTime=1;
		}
	}
}
