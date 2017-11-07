using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManagement : MonoBehaviour {

	float PriceTime;
	int speedlevel =0;
	int pricespeed=60;
	public int plusspeed=3;
	public Text speedtx;
	public Text speedlvtx;
	int pluslevel =0;
	int upplustime =0;
	int priceup=100;
	public Text plustx;
	public Text pluslvtx;
	int minuslevel =0;
	int downminustime =0;
	int pricedown=100;
	public Text minustx;
	public Text minuslvtx;
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		PriceTime = ObjectMaker.instance.timecheck;
		speedtext ();
		plustext ();
		minustext ();
	}

	void speedtext(){
		if (speedlevel != 5) {
			int minute = pricespeed % 60;
			int hour = pricespeed / 60;
			speedtx.text = "소모시간 : " + hour.ToString ("00") + ":" + minute.ToString ("00");
			speedlvtx.text = "Level:" + speedlevel.ToString ();
		} else if (speedlevel == 5) {
			speedtx.text = "더이상구매할수없습니다.";
			speedlvtx.text = "Level:" + speedlevel.ToString ();
		}
	}
	void plustext(){
		if (pluslevel != 5) {
			int minute = priceup % 60;
			int hour = priceup / 60;
			plustx.text = "소모시간 : " + hour.ToString ("00") + ":" + minute.ToString ("00");
			pluslvtx.text = "Level:" + pluslevel.ToString ();
		} else if (pluslevel == 5) {
			plustx.text = "더이상구매할수없습니다.";
			pluslvtx.text = "Level:" + pluslevel.ToString ();
		}
	}
	void minustext(){
		if (minuslevel != 5) {
			int minute = pricedown % 60;
			int hour = pricedown / 60;
			minustx.text = "소모시간 : " + hour.ToString ("00") + ":" + minute.ToString ("00");
			minuslvtx.text = "Level:" + minuslevel.ToString ();
		} else if (minuslevel == 5) {
			minustx.text = "더이상구매할수없습니다.";
			minuslvtx.text = "Level:" + minuslevel.ToString ();
		}
	}

	public void SpeedLevelUp(){
		if (speedlevel == 0 && PriceTime >= pricespeed) {
			ObjectMaker.instance.timecheck -= pricespeed;
			pricespeed = 120;
			speedlevel = 1;
			int Upspeed = plusspeed * speedlevel;
			GameObject.Find ("player master").GetComponent<Run> ().itemupspeed (Upspeed);
		}else if (speedlevel == 1 && PriceTime >= pricespeed){
			ObjectMaker.instance.timecheck -= pricespeed;
			pricespeed = 180;
			speedlevel = 2;
			int Upspeed = plusspeed * speedlevel;
			GameObject.Find ("player master").GetComponent<Run> ().itemupspeed (Upspeed);
		}
		else if (speedlevel == 2 && PriceTime >= pricespeed){
			ObjectMaker.instance.timecheck -= pricespeed;
			pricespeed = 240;
			speedlevel = 3;
			int Upspeed = plusspeed * speedlevel;
			GameObject.Find ("player master").GetComponent<Run> ().itemupspeed (Upspeed);
		}
		else if (speedlevel == 3 && PriceTime >= pricespeed){
			ObjectMaker.instance.timecheck -= pricespeed;
			pricespeed = 300;	
			speedlevel = 4;
			int Upspeed = plusspeed * speedlevel;
			GameObject.Find ("player master").GetComponent<Run> ().itemupspeed (Upspeed);
		}
		else if (speedlevel == 4 && PriceTime >= pricespeed){
			ObjectMaker.instance.timecheck -= pricespeed;
			pricespeed = 360;
			speedlevel = 5;
			int Upspeed = plusspeed * speedlevel;
			GameObject.Find ("player master").GetComponent<Run> ().itemupspeed (Upspeed);
		}
	}
	public void plusLevelUp(){
		if (pluslevel == 0 && PriceTime >= priceup) {
			ObjectMaker.instance.timecheck -= priceup;
			priceup = 200;
			upplustime = 10;
			pluslevel = 1;
			int uptime = ObjectMaker.instance.BasePlusTime_Mini;
			int plusup = (uptime *upplustime)/100;
			ObjectMaker.instance.itemplustime (plusup);
		} else if (pluslevel == 1 && PriceTime >= priceup) {
			ObjectMaker.instance.timecheck -= priceup;
			priceup = 300;
			upplustime = 20;
			pluslevel = 2;
			int uptime = ObjectMaker.instance.BasePlusTime_Mini;
			int plusup = (uptime *upplustime)/100;
			ObjectMaker.instance.itemplustime (plusup);
		}else if (pluslevel == 2 && PriceTime >= priceup) {
			ObjectMaker.instance.timecheck -= priceup;
			priceup = 400;
			upplustime = 30;
			pluslevel = 3;
			int uptime = ObjectMaker.instance.BasePlusTime_Mini;
			int plusup = (uptime *upplustime)/100;
			ObjectMaker.instance.itemplustime (plusup);
		}else if (pluslevel == 3 && PriceTime >= priceup) {
			ObjectMaker.instance.timecheck -= priceup;
			priceup = 500;
			upplustime = 40;
			pluslevel = 4;
			int uptime = ObjectMaker.instance.BasePlusTime_Mini;
			int plusup = (uptime *upplustime)/100;
			ObjectMaker.instance.itemplustime (plusup);
		}else if (pluslevel == 4 && PriceTime >= priceup) {
			ObjectMaker.instance.timecheck -= priceup;
			priceup= 600;
			upplustime = 50;
			pluslevel = 5;
			int uptime = ObjectMaker.instance.BasePlusTime_Mini;
			int plusup = (uptime *upplustime)/100;
			ObjectMaker.instance.itemplustime (plusup);
		}
	}
	public void minusLevelUp(){
		if ( minuslevel == 0 && PriceTime >= pricedown) {
			ObjectMaker.instance.timecheck -= pricedown;
			pricedown = 200;
			downminustime = 10;
			minuslevel = 1;
			int downtime = ObjectMaker.instance.BaseMinusTime_Mini;
			int plusdown = (downtime *downminustime)/100;
			ObjectMaker.instance.itemminustime (plusdown);
		} else if ( minuslevel == 1 && PriceTime >=  pricedown) {
			ObjectMaker.instance.timecheck -= pricedown;
			priceup = 300;
			downminustime = 20;
			minuslevel = 2;
			int downtime = ObjectMaker.instance.BaseMinusTime_Mini;
			int plusdown = (downtime *downminustime)/100;
			ObjectMaker.instance.itemminustime (plusdown);
		}else if ( minuslevel == 2 && PriceTime >=  pricedown) {
			ObjectMaker.instance.timecheck -= pricedown;
			pricedown = 400;
			downminustime = 30;
			minuslevel = 3;
			int downtime = ObjectMaker.instance.BaseMinusTime_Mini;
			int plusdown = (downtime *downminustime)/100;
			ObjectMaker.instance.itemminustime (plusdown);
		}else if ( minuslevel == 3 && PriceTime >=  pricedown) {
			ObjectMaker.instance.timecheck -= pricedown;
			pricedown = 500;
			downminustime = 40;
			minuslevel = 4;
			int downtime = ObjectMaker.instance.BaseMinusTime_Mini;
			int plusdown = (downtime *downminustime)/100;
			ObjectMaker.instance.itemminustime (plusdown);
		}else if ( minuslevel == 4 && PriceTime >=  pricedown) {
			ObjectMaker.instance.timecheck -= pricedown;
			pricedown= 600;
			downminustime = 50;
			minuslevel = 5;
			int downtime = ObjectMaker.instance.BaseMinusTime_Mini;
			int plusdown = (downtime *downminustime)/100;
			ObjectMaker.instance.itemminustime (plusdown);
		}
	}
}
