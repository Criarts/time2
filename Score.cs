using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

	public int GameScore=0;
	public int BossMeetScore=200;

	IEnumerator ScoreCoroutine()
	{
		while (ObjectMaker.instance.Die==0) {
			yield return new WaitForSeconds (ObjectMaker.instance.TimeSpeed);
				GameScore++;
		}
	}


	// Use this for initialization
	void Start () {
		StartCoroutine (ScoreCoroutine ());
	}
	
	// Update is called once per frame
	void Update () {
		if (GameScore >= BossMeetScore) {
			ObjectMaker.instance.BossMeet ();
		}
	}

	public int PlusScore(){
		GameScore += ObjectMaker.instance.PlusTime_Mini;
		return GameScore;
	}
}
