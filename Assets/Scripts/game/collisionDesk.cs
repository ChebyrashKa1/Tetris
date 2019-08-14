using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionDesk : MonoBehaviour {

	public static bool can = false;
	public static GameObject objectControlBlock;
	public static Vector2 posControlBlock;

	void OnTriggerStay2D(Collider2D col){
		if (col.gameObject.tag == "PivotBlock"){// && !this.gameObject.GetComponentInParent<Controller>().isActiveAndEnabled) {
			this.gameObject.tag = "StayBlock";
			col.gameObject.GetComponent<whiteBlock> ().enabled = true;
			this.gameObject.GetComponent<collisionDesk> ().enabled = false;
		}
	}

	void OnCollisionStay2D(Collision2D col){
		if (col.gameObject.tag == "StayBlock" && stateBlock.dragOff) {
			stateBlock.dragOff = false;
			can = false;
			objectControlBlock.transform.position = posControlBlock; //new Vector2 (0, -4f);
			Debug.Log ("OnCollisionStay2D Can: " + can);
		} else if (stateBlock.dragOff) {
			can = true;
			Debug.Log ("OnCollisionStay2D Can: " + can);
		}
	}
}
