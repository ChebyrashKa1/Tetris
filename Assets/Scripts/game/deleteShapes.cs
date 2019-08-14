using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteShapes : MonoBehaviour {

	void Update () {
		if (this.gameObject.transform.childCount < 2)
			Destroy (this.gameObject);
	}
}
