using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed; // Speed multiplier for player ship
	float xMin, xMax; // boundaries
	public float padding; // boundaries + padding = playspace
	public GameObject laser;
	public float laserSpeed;
	public float fireRate = 0.2f;

	// Use this for initialization
	void Start () {
		xMin = Camera.main.ViewportToWorldPoint(new Vector3(0,0,-10)).x + padding;
		xMax = Camera.main.ViewportToWorldPoint(new Vector3(1,0,-10)).x - padding;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 position = transform.position + new Vector3(Input.GetAxis("Horizontal")*speed*Time.deltaTime,0,0);
		transform.position = new Vector3(Mathf.Clamp(position.x,xMin,xMax),transform.position.y,transform.position.z);
		if(Input.GetKeyDown(KeyCode.Space))
		{
			InvokeRepeating("Fire",0.00001f,fireRate);
		}
		if (Input.GetKeyUp(KeyCode.Space)) {
			CancelInvoke("Fire");
		}

	}

	void Fire(){
		Debug.Log("Firing");
		GameObject laserbeam = Instantiate(laser,transform.position,Quaternion.identity) as GameObject; 
		laserbeam.GetComponent<Rigidbody2D>().velocity = new Vector3(0,laserSpeed,0);
	}
}
