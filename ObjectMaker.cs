//최종 수정자:김영민
//수정날짜: 2017/09/24
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class ObjectMaker : MonoBehaviour {
	
	public static ObjectMaker instance;
	public Transform Ground;
	Vector3 GroundPPos;
	public List<Transform> obstacles = new List<Transform> ();
	public Transform obstacle;
	int ObstacleOrder;
	public int timecheck = 30;
	public Text tx;
	public int StopCheck = 0;
	public int StopTime = 0;
	public float	TimeSpeed = 1f;
	public int Die = 0;
	public int MiniCheck = 0;
	public int ObstacleCheck = 0;
	public int	BasePlusTime_Mini = 30;
	public int BaseMinusTime_Mini = 30;
	public int PlusTime_Mini;
	public int MinusTime_Mini;
	public GameObject panel;
	public 	GameObject DieResult;
	public GameObject BossDore;
	public GameObject Item;
	int BossSpawnCheck = 0;

	void Awake()
	{
		instance = this;
	}

	IEnumerator timer()
	{
		while (Die == 0) {
			yield return new WaitForSeconds (TimeSpeed);
			if (StopTime == 0) {
				timecheck--;
				int Hour = timecheck / 60;
				int Minute = timecheck % 60;
				tx.text = Hour.ToString ("00") + ":" + Minute.ToString ("00");
			}
		}
	}

	public int PlusTimer(){
		GameObject.Find ("Score").GetComponent<Score> ().PlusScore ();
		timecheck += PlusTime_Mini ;
		return timecheck;
	}

	public int MinusTimer(){
		timecheck -= MinusTime_Mini ;
		return timecheck;
	}
	public int itemplustime(int itemtime){
		PlusTime_Mini =BasePlusTime_Mini+ itemtime;
		return PlusTime_Mini;
	}
	public int itemminustime(int itemtime){
		MinusTime_Mini =BaseMinusTime_Mini- itemtime;
		return MinusTime_Mini;
	}
		

	// Use this for initialization
	void Start () {
		PlusTime_Mini = BasePlusTime_Mini;
		MinusTime_Mini = BaseMinusTime_Mini;
		if (StopCheck == 0) {
			for (int i = 0; i < 10; i++) {
			
				Transform newObstacle = Instantiate (obstacle);
				obstacles.Add (newObstacle);
				Transform newGround = Instantiate (Ground);
				SpawnGround (newGround);
				newObstacle.gameObject.SetActive (false);
			}
		}
			StartCoroutine (timer ());
	}

	void Update () {
		Debug.Log (PlusTime_Mini);
		if (timecheck<=0) {
			Die = 1;
			tx.text = "0";
			OnStop ();
			DieResult.gameObject.SetActive (true);
		}
	}
		
	public void SpawnGround(Transform G){
		G.position = GroundPPos;
		Vector3 GroundInterval = new Vector3 (0, 0, 15f);
		GroundPPos += GroundInterval;
		if (ObstacleCheck == 0 && GameObject.Find("Score").GetComponent<Score>().GameScore>1) {
			SpawnObstacle (G);
		}
		SpawnBossDore(G);
	}

	public void	SpawnObstacle(Transform G){
			int ObstacleMaxnumber = 11;
			int ObstacleNumber = Random.Range (0, ObstacleMaxnumber);
			if (ObstacleNumber > ObstacleMaxnumber - 4) {
				obstacles [ObstacleOrder].gameObject.SetActive (true);
				obstacles [ObstacleOrder].parent = G;
				obstacles [ObstacleOrder].localRotation = Quaternion.Euler (Vector3.zero);

				if (ObstacleNumber == ObstacleMaxnumber - 3) {
					obstacles [ObstacleOrder].localPosition = new Vector3 (0, 0f, -5f);
				} else if (ObstacleNumber == ObstacleMaxnumber - 2) {
					obstacles [ObstacleOrder].localPosition = new Vector3 (1.3f, 0f, -5f);
				} else if (ObstacleNumber == ObstacleMaxnumber - 1) {
					obstacles [ObstacleOrder].localPosition = new Vector3 (-1.3f, 0f, -5f);
				}
				ObstacleOrder++;
				if (ObstacleOrder > 6) {
					ObstacleOrder = 0;
				}
			}
	}

	public void SpawnBossDore(Transform G){
		if (ObstacleCheck == 1) {
			if (BossSpawnCheck == 0) {
				GameObject BossPos = Instantiate (BossDore);
				BossPos.transform.position = new Vector3 (G.position.x, 2.5f, G.position.z);
				BossSpawnCheck++;
			}
		}
	}
	public int OnStop (){
		StopCheck = 1;
		return StopCheck;
	}

	public void RunCheck(){
		if (MiniCheck == 0) {
			StopCheck = 0;
			GameObject.Find ("GameManager").GetComponent<PlayerHealth> ().MiniPauseCheck = 0;
		} else if (MiniCheck == 1) {
			GameObject.Find ("GameManager").GetComponent<PlayerHealth> ().MiniPauseCheck = 0;
		}
	}

	public int  MiniGameCheck(){
		MiniCheck = 1;
		OnStop ();
		return MiniCheck;
	}
	public int  MiniGameFinishCheck(){
		MiniCheck = 0;
		return MiniCheck;
	}
	public void Pause(){
		StopTime= 1;
		GameObject.Find ("GameManager").GetComponent<PlayerHealth> ().MiniPauseCheck = 1;
		OnStop ();
		panel.gameObject.SetActive (true);
	}

	public void Continue(){
		StopTime = 0;
		RunCheck();
		panel.gameObject.SetActive (false);
	}
	public void BossMeet(){ 
		ObstacleCheck = 1;
	}
	public void BossStart(){
		OnStop ();
		GameObject.Find ("ObjectMaker").GetComponent<SceneChange> ().Change1RoundBoss ();
	}
	public  void ItemUIOn(){
		Item.gameObject.SetActive (true);
	}
}
