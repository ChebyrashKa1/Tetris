using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whiteBlock : MonoBehaviour {

	public static int rowCheckBlocks;

	void OnTriggerStay2D(Collider2D col){
		if (col.gameObject.tag == "StayBlock" 
			&& this.gameObject.transform.childCount < 1 
			&& col.gameObject.transform.parent.gameObject != this.gameObject
			&& !col.gameObject.GetComponentInParent<Controller> ().isActiveAndEnabled) { 
			rowCheckBlocks = int.Parse (this.gameObject.name);
			col.transform.parent = this.transform;
			spawnBlock.calcChild = true;
			this.GetComponent<whiteBlock> ().enabled = false;
		}
	}
}