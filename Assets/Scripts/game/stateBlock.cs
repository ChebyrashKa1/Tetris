using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stateBlock : MonoBehaviour {

	Vector3 tempPos;
	public static bool dragOff;
	public static int countBlockStay = 3;

	void Start(){
		dragOff = false;
	}

	void Update(){
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "PivotBlock") {
			tempPos = col.gameObject.transform.position;
		}
	}

	void OnTriggerStay2D(Collider2D col){
		if (col.gameObject.tag == "PivotBlock" && collisionDesk.can && dragOff) {

			if (col.gameObject.transform.position == tempPos) {
				this.gameObject.transform.parent.position = tempPos;
			} else
				this.gameObject.transform.parent.position = tempPos;

			this.gameObject.GetComponentInParent<Controller> ().enabled = false;

			if (!collisionDesk.objectControlBlock.GetComponentInParent<Controller> ().isActiveAndEnabled) {
				countBlockStay++;
				moves.move--;
			}

			dragOff = false;
			collisionDesk.can = false;
			Debug.Log ("Pivot Block " + dragOff);

			this.gameObject.GetComponent<stateBlock> ().enabled = false;		
		}
	}
}

