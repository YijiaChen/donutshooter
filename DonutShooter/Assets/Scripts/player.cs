﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
    public float movespeedx;
    public float movespeedy;
    private Rigidbody2D rb;
    public GameObject donut;
    public int shootrate = 1;
    private int shoottimer;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>(); 
	}
	
	// Update is called once per frame
	void Update () {
        shoottimer += 1;
        //movement
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector2(0,movespeedy);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector2(0, -movespeedy);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-movespeedx, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(movespeedx, 0);
        }
        else
        {
            rb.velocity = new Vector2(0, 0);
        }
        // shooting donut
        if (Input.GetKey(KeyCode.Space))
        {
            //bruhhhhhhhhhh
            if (shoottimer%shootrate==0)
            {
                Vector3 newPos = new Vector3(rb.position.x, rb.position.y, 0);
                Instantiate(donut, newPos, Quaternion.identity);
                Debug.Log("BRUHHHHHHHHHHHHH");
            }
        }

		
	}
}
