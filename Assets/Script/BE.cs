using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BE : MonoBehaviour {

	public GameObject block;
	public float speed;
	private Rigidbody rb;
	Animator anim;
	public Vector3[] spawnPositions;
	static int numOfPlayers;
	public int direction;
	private double timer = 3;
	void OnCollisionStay(Collision other){
		
		destruction (other);
	}
	void destruction(Collision other){
		if (Input.GetKey(KeyCode.F)) {
			if (other.gameObject.tag == "normalblock") {
				Destroy (other.gameObject);
			} else if (other.gameObject.tag == "immortalblock") {
			
			}

		}
	}

	void construction(){
		Vector3 pos = gameObject.transform.position;
		switch (direction) {
		case 1:
			pos.x += 0.5f;
			break;
		case -1:
			pos.x-=0.5f;
			break;
		case 2:
			pos.y += 0.5f;
			break;
		case -2:
			pos.y -= 0.5f;
			break;
	
		}

		if (timer < 3) {
			Instantiate (block, pos, Quaternion.identity);
			timer = 5;
		}
	}

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		anim = GetComponent<Animator> ();
		//transform.position = spawnPositions[numOfPlayers];
	}
	/*void FixedUpdate()
	{
collider
		float lastInputX = Input.GetAxis ("Horizontal");
		float lastInputY = Input.GetAxis ("Vertical");

		if (lastInputX != 0 || lastInputY != 0) {
			anim.SetBool ("walking", true);

getkey
			if (lastInputX > 0) {
				anim.SetFloat ("LastMoveX", 1f);
			} else if (lastInputX < 0) {
				anim.SetFloat ("LastMoveX", -1f);
			} else {
				anim.SetFloat ("LastMoveX", 0f);
			}

			if (lastInputY > 0) {
				anim.SetFloat ("LastMoveY", 1f);
			} else if (lastInputY < 0) {
				anim.SetFloat ("LastMoveY", -1f);
			} else {
				anim.SetFloat ("LastMoveY", 0f);
			}
GameController

		} else {
			anim.SetBool ("walking", false);
		}
	}
	*/
	// Update is called once per frame
	void Update () {
		float x = Input.GetAxisRaw ("Horizontal");
		float y = Input.GetAxisRaw ("Vertical");
		bool z = Input.GetKey (KeyCode.F);
		if(Mathf.Abs(x)>=Mathf.Abs(y)){
			y = 0;
			if (x > 0) {
				direction = 1;
			}
			else {
				direction = -1;
			}
		}
		if (Mathf.Abs (y) >= Mathf.Abs (x)) {
			x = 0;
			if (y > 0) {
				direction = 2;
			} else {
				direction = -2;
			}
		}
		if (z) {
			construction ();
		}
		Vector2 movement = new Vector2 (x, y)*speed;
		rb.velocity = movement;
	
		//anim.SetFloat ("SpeedX", x);
		//anim.SetFloat ("SpeedY", y);
		timer-= Time.deltaTime;
	}
}
