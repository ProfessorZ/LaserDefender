using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {
	public GameObject enemyPrefab;
	// Use this for initialization
	void Start () {


		foreach (Transform position in transform) {
			GameObject enemy = Instantiate(enemyPrefab,position.transform.position,Quaternion.identity) as GameObject;  // instantiate new Enemy GameObject
			enemy.transform.parent = position; // put Enemy instance under EnemyFormation GO
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
