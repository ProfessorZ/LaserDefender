using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed; // Speed multiplier for player ship
	float xMin, xMax; // boundaries
	public float padding; // boundaries + padding = playspace

	// Use this for initialization
	void Start () {
		xMin = Camera.main.ViewportToWorldPoint(new Vector3(0,0,-10)).x + padding;
		xMax = Camera.main.ViewportToWorldPoint(new Vector3(1,0,-10)).x - padding;
		Debug.Log(xMin + " " + xMax);

	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(Input.GetAxis("Horizontal"));
		Vector3 position = transform.position + new Vector3(Input.GetAxis("Horizontal")*speed*Time.deltaTime,0,0);
		transform.position = new Vector3(Mathf.Clamp(position.x,xMin,xMax),transform.position.y,transform.position.z);
	}
}
