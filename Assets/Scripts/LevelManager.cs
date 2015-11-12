using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadNewLevel(string levelName){
		Application.LoadLevel(levelName);
	}

	public void Quit(){
		Application.Quit();
	}
}
