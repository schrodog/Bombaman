using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {


    private float speed = 15f;
    // Use this for initialization

    private Rigidbody rb;
	void Start () {
        GetComponent<Renderer>().material.color = new Color(0.5f, 1, 1); //C#
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {

    }

    void FixedUpdate() {
        rb.velocity = new Vector2(0f, 0f);
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector2(0f, speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector2(0f, -speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-speed, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(speed, 0f);
        }
    }
}
