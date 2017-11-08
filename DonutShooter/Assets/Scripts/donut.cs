using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class donut : MonoBehaviour {
    private Rigidbody2D rb;
    public float bulletspeed;
    public float lifespan;
    Collider2D m_collider;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(bulletspeed, 0);
        m_collider = GetComponent<Collider2D>();
        
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
        if (collision.collider.tag == "monster2")
        {
            rb.velocity = new Vector2(-8, 5);
            rb.angularVelocity = 720.0f;
            m_collider.enabled = !m_collider.enabled;
        
        }
        if (collision.collider.tag == "monster3")
        {
            rb.velocity = new Vector2(-8, 5);
            rb.angularVelocity = 720; 
            m_collider.enabled = !m_collider.enabled;

        }
       

    }
}
