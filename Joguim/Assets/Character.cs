using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

	public GameController GC;

	// Use this for initialization
	void Start () {
		GC = GameObject.Find ("GameController").GetComponent<GameController>();
	}
	
	// Update is called once per frame
	void Update () {

		if (GC.selectedChar == this) {
			if (Input.GetKeyDown (KeyCode.LeftArrow))
				transform.Translate (Vector2.left);

			if (Input.GetKeyDown (KeyCode.RightArrow))
				transform.Translate (Vector2.right);
		}

	}


}
