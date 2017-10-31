using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
    public float movespeedx;
    public float movespeedy;
    private Rigidbody2D rb;
    public GameObject donut;
    public GameObject donut2;
    public GameObject donut3;
    private int donutType = 1;
    public int shootrate = 1;
    private int shoottimer;
    public int donutnum;
    public int refill;
    public TextMesh donutdisplay;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>(); 
	}
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "reload")
        {
            donutType = 1;
            donutnum = refill; 
        }
        if (collision.collider.tag == "reload2")
        {
            donutType = 2;
            donutnum = refill;

        }
    }

    // Update is called once per frame
    void Update () {
        donutdisplay.text = donutnum.ToString();
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
        if (Input.GetKey(KeyCode.Space)&&(donutnum>0))
        {
            //the greater the number, the slower of shoot rate;kinda anti-intuitive...
            if (shoottimer%shootrate==0)
            {
                if (donutType == 1)
                {
                    Vector3 newPos = new Vector3(rb.position.x+1.0f, rb.position.y, 0);
                    Instantiate(donut, newPos, Quaternion.identity);
                    donutnum -= 1;
                    shoottimer = 0;
                }
                if (donutType == 2)
                {
                    Vector3 newPos = new Vector3(rb.position.x + 1.0f, rb.position.y, 0);
                    Instantiate(donut2, newPos, Quaternion.identity);
                    donutnum -= 1;
                    shoottimer = 0;
                }
            }
        }

		
	}
}
