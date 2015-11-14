using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {
	public GameObject enemyPrefab;
	public float width;
	public float height;
	public float enemySpeed = 2;
	
	public float xMin,xMax;
	// Use this for initialization
	void Start () {
		
		
		foreach (Transform position in transform) {
			GameObject enemy = Instantiate(enemyPrefab,position.transform.position,Quaternion.identity) as GameObject;  // instantiate new Enemy GameObject
			enemy.transform.parent = position; // put Enemy instance under EnemyFormation GO
		}
	}
	
	public void OnDrawGizmos(){
		Gizmos.DrawWireCube(transform.position, new Vector3(width,height));
	}
	
	// Update is called once per frame
	void Update () {
		xMin = Camera.main.ViewportToWorldPoint(new Vector3(0,0,-10)).x;
		xMax = Camera.main.ViewportToWorldPoint(new Vector3(1,0,-10)).x;
		transform.position += new Vector3(enemySpeed*Time.deltaTime,0,0);
		if (((transform.position.x-(0.5f*width)) < xMin && enemySpeed < 0) || 
		    (transform.position.x+(0.5f*width)) > xMax && enemySpeed > 0 || 
		    (transform.position.x-(0.5f*width)) < xMin || (transform.position.x+(0.5f*width)) > xMax ) 
		{
			enemySpeed *= -1;
		}
	}
}