using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moves : MonoBehaviour {

	public static int move;
	Text t;
	public GameObject panelGameOver;

	void Start () {
		t = GetComponent<Text> ();
		move = 50;
	}
	
	void Update () {
		if(t.text != move.ToString())
			t.text = "Moves: " + move;
		if(move < 1)
			panelGameOver.SetActive (true);
	}

	public void EndFunc(){
		panelGameOver.SetActive (true);
	}
}
