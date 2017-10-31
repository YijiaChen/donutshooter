using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class donut : MonoBehaviour {
    private Rigidbody2D rb;
    public float bulletspeed;
    public float lifespan;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(bulletspeed, 0);
	}
	
	// Update is called once per frame
	void Update () {
        lifespan -= Time.deltaTime;
        if (lifespan <= 0)
        {
            Destroy(this.gameObject);
        }
		
	}
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "monster1")
        {
            Destroy(this.gameObject);
        }
    }
}
