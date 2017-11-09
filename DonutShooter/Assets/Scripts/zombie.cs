using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie : MonoBehaviour {
    float flip;
    public int hitpoints;
    public TextMesh hittext;
    public float movingSpeed;
    GameObject score;
    Collider2D m_collider;
    bool hitbyright;
    public GameObject blood;

	// Use this for initialization
	void Start () {
        score = GameObject.Find("scorer");
        m_collider = GetComponent<Collider2D>();
        hitbyright = false;

		
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x > -6.5f && hitbyright==false)
        {
          transform.Translate(-movingSpeed, 0, Time.deltaTime);
        }
        if (transform.position.x <= -6.5f)
        {   // game should be over by now 
            transform.Translate(0, 0, Time.deltaTime);
        }
        if (hitbyright == true)
        {
            transform.Translate(0.05f, 0, Time.deltaTime);
            if (transform.position.x >= 20)
            {
                Destroy(this.gameObject);
            }
        }
        hittext.text = hitpoints.ToString();
        if (hitpoints <= 0)
        {
            Instantiate(blood, transform.position, Quaternion.identity);
            score.SendMessage("killed");
            Destroy(this.gameObject);
           
        }
		
	}
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "bullet")
        {
            //get the right donut, and turn back.
            hitbyright = true;
            m_collider.enabled = !m_collider.enabled;
            score.SendMessage("returned");
            flip = this.gameObject.transform.localScale.x;
            this.gameObject.transform.localScale += new Vector3(-flip * 2, 0, 0);
        }
        if (collision.collider.tag == "bullet2")
        {   
          hitpoints -= 1;
          Debug.Log("hit");

        }
        if (collision.collider.tag == "bullet3")
        {
            hitpoints -= 1;
            Debug.Log("hit");

        }
        //when spawned, avoid overlap
        if (collision.collider.tag == "monster1")
        {
            Destroy(this.gameObject);
           
        }
      

    }
}
