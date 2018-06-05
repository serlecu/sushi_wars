using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parent : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.transform.SetParent (GameObject.FindGameObjectWithTag("Canvas").transform, false);
	}
}
