using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

	public float max_health = 100f;
	public float cur_health = 0f;
	public float speed = 1f;
	public GameObject HealthBar;
	public int RepeatCheck = 0;
	public float Health;
	GameObject Result;
	public GameObject ArmBattle;
	public int ResultCheck=0 ;
	public GameObject WinResult;
	public GameObject LoseResult;
	public int MiniPauseCheck = 0;

	// Use this for initialization
	void Start () {
		cur_health = max_health * 0.4f;
		InvokeRepeating ("decreasehealth", 1f, speed);
	}
	
	// Update is called once per frame
	void Update () {
		WinCheck ();
		LoseCheck ();
	}

	float decreasehealth(){
		if (ResultCheck == 0) {
			if (MiniPauseCheck == 0) {
				cur_health -= 3f;
				float calc_health = cur_health / max_health;
				setbar (calc_health);
				Health = cur_health;
			}
		}
		return Health;
	}

	public void setbar(float myhealth){
		if (myhealth < 1) {
			HealthBar.transform.localScale = new Vector3 (myhealth, HealthBar.transform.localScale.y, HealthBar.transform.localScale.z);
		} else if (myhealth >= 1) {
			myhealth = 1;
			HealthBar.transform.localScale = new Vector3 (myhealth, HealthBar.transform.localScale.y, HealthBar.transform.localScale.z);
		}
	}

	public void Right(){
		if (RepeatCheck == 0) {
				ArmBattle.transform.Rotate (20, 0, 0);
				cur_health += 5f;
				RepeatCheck = 1;
		}
		else{
			cur_health -= 1;
		}
	}

	public void Left(){
		if (RepeatCheck == 1) {
			ArmBattle.transform.Rotate (-20,0,0);
			cur_health += 5f;
			RepeatCheck = 0;
		}
		else{
			cur_health -= 1f;
		}
	}
	public void WinCheck(){
		if (Health >= 100) {
			ResultCheck = 1;
			WinResult.gameObject.SetActive (true);
		}
	}
	public void LoseCheck(){
		if (Health < 0) {
			ResultCheck = 2;
			LoseResult.gameObject.SetActive (true);
		}
	}
	public void Reset(){
		WinResult.gameObject.SetActive (false);
		LoseResult.gameObject.SetActive (false);
		ResultCheck = 0;
		cur_health = max_health * 0.4f;
		Health = cur_health;
		HealthBar.transform.localScale = new Vector3 (cur_health/max_health, HealthBar.transform.localScale.y, HealthBar.transform.localScale.z);
	}
}
