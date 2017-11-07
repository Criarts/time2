using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour {

	public void Changeplay(){
		SceneManager.LoadScene ("play");
	}
	public void ChangeMain(){
		SceneManager.LoadScene ("Main");
	}
	public void Change1RoundBoss(){
		SceneManager.LoadScene ("1RoundBoss");
	}
}
