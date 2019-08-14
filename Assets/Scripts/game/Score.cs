using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour {

	Text tScore;
	public static int countScore = 0;
	public int indexText;

	void Start () {
		tScore = GetComponent<Text> ();
		if(indexText == 1 && PlayerPrefs.HasKey("MaxScore"))
			tScore.text = "MaxScore: " + PlayerPrefs.GetInt("MaxScore");

	}
	
	void Update () {
		if(indexText == 0)
			tScore.text = "Score: " + countScore;
	}

	public void RestartScene(){
		stateBlock.countBlockStay = 3;
		if(PlayerPrefs.GetInt("MaxScore") < countScore)
			PlayerPrefs.SetInt("MaxScore", countScore);
		countScore = 0;
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
	}
}
