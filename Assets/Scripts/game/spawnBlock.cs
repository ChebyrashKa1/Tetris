using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBlock : MonoBehaviour {

	public GameObject[] blocks = new GameObject[7];
	int[] threeBlocks = new int[3];
	float xCorrect;
	int rowDestroy;
	public GameObject whiteBlocks;
	public static GameObject[,] whiteBlocksMassive = new GameObject[10, 10];
	float posX = -3.67f, posY = 4.4f;

	AudioSource audSource;
	public AudioClip clip;

	public static bool calcChild;
	int countBlocksWithChild;

	void Start () {
		audSource = GetComponent<AudioSource> ();

		for (int i = 0; i < 10; i++) {
			for (int j = 0; j < 10; j++) {
				whiteBlocksMassive[i,j] = Instantiate(whiteBlocks,new Vector2(posX += 0.67f, posY),Quaternion.identity, this.gameObject.transform);
				whiteBlocksMassive[i,j].name  = (i).ToString ();
			}
			posX = -3.67f; 
			posY -= 0.675f;
		}
		InvokeRepeating ("RandomBlocks", 0.1f, 1f);
	}
	
	void Update () {
		if (calcChild) {
			calcChild = false;
			SearchRow (whiteBlock.rowCheckBlocks);

		}
			
		if (countBlocksWithChild == 10) {
			countBlocksWithChild = 0;
			DestroyLine (rowDestroy);
		}
	}

	void RandomBlocks(){
		if (stateBlock.countBlockStay == 3 && moves.move != 0) {
			for (int i = 0; i < 3; i++) {
				xCorrect = 2.75f * i;
				threeBlocks [i] = Random.Range (0, 7); //0...7
				Instantiate (blocks [threeBlocks [i]], new Vector2 (-2.75f + xCorrect, -4f), Quaternion.identity);
			}
			stateBlock.countBlockStay = 0;
		}
	}

	public void DestroyLine(int index){
		for (int i = 0; i < 10; i++) {				
			Destroy (whiteBlocksMassive [index, i].transform.GetChild (0).gameObject);
		}
		Score.countScore += 100;
		moves.move++;
		audSource.PlayOneShot (clip);
	}

	public void SearchRow(int index){
		rowDestroy = -1;
		for (int i = 0; i < 10; i++) {	
			countBlocksWithChild = 0;
			for (int j = 0; j < 10; j++) {			
				if (whiteBlocksMassive [i, j].transform.childCount > 0) {
					countBlocksWithChild++;
					if (countBlocksWithChild == 10) {
						rowDestroy = i;
						return;
					}
				} else
					break;
			}
		}
	}
}
