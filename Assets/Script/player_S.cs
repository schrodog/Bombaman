using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_S : MonoBehaviour {
	public float speed;
	private Rigidbody rb;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();

	}
	
	// Update is called once per frame
	void Update () {
		float x = Input.GetAxisRaw ("Horizontal");
		float y = Input.GetAxisRaw ("Vertical");
		/*if(Mathf.Abs(x)>=Mathf.Abs(y)){
			y = 0;
	        }
		if(Mathf.Abs(y)>=Mathf.Abs(x)){
			x=0;
			}
         */ 
		Vector2 movement = new Vector2 (x, y)*speed;
		rb.velocity = movement;
	  }
}
