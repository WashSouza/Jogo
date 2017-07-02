using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameController : MonoBehaviour {

	public Character char1;
	public Character char2;
	public Character[] currentChars;
	public Character selectedChar;

	// Use this for initialization
	void Start () {

		currentChars = new Character[2];

		currentChars [0] = char1;
		currentChars [1] = char2;

		selectedChar = currentChars [0];
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown (KeyCode.Alpha1) || 
			Input.GetKeyDown (KeyCode.Alpha2) || 
			Input.GetKeyDown (KeyCode.Alpha3) || 
			Input.GetKeyDown (KeyCode.Alpha4)) {

			changeChar (detectPressedKey());
		}
		
	}

	void changeChar(KeyCode key){

		selectedChar.gameObject.SetActive(false);

		if (key == KeyCode.Alpha1)
			selectedChar = currentChars [0];
		else if(key == KeyCode.Alpha2)
			selectedChar = currentChars [1];
		else if(key == KeyCode.Alpha3)
			selectedChar = currentChars [3];
		else if(key == KeyCode.Alpha4)
			selectedChar = currentChars [4];

		selectedChar.gameObject.SetActive(true);
	
	}

	public KeyCode detectPressedKey(){

		KeyCode key = KeyCode.Alpha0;

		foreach(KeyCode keyCode in Enum.GetValues(typeof(KeyCode))){
			if (Input.GetKeyDown (keyCode))
				key = keyCode;
		}

		return key;
	}
}
