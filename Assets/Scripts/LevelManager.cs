﻿using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name){
		Application.LoadLevel (name);
		Debug.Log ("Level load requested for: " + name); 
	}
	public void QuitRequest(){
		Application.Quit ();
		Debug.Log ("I wanna quit!"); 
	}
	public void LoadNextLevel(){
		Application.LoadLevel(Application.loadedLevel + 1);
	}
	public void BrickDestroyed(){
		if (Brick.breakableCount <=0){
			LoadNextLevel();
		}
	}
}
