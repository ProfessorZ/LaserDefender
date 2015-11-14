using System.Collections;
using UnityEngine;

public class EnemyHit : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter2D(Collider2D coll){
		Debug.Log("Hit!");

		if (coll.gameObject.GetComponent<Laser>()) {
			Debug.Log("LaserHit!");
			Destroy (coll.gameObject);
		}
		
	}
}
