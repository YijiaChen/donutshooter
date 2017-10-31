using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie : MonoBehaviour {
    public int hitpoints;
    public TextMesh hittext;
    public float movingSpeed;
    GameObject score;

	// Use this for initialization
	void Start () {
        score = GameObject.Find("scorer");

		
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x > -6.5f)
        {
          transform.Translate(-movingSpeed, 0, Time.deltaTime);
        }
        if (transform.position.x <= -6.5f)
        {   // game should be over by now 
            transform.Translate(0, 0, Time.deltaTime);
        }
        hittext.text = hitpoints.ToString();
        if (hitpoints <= 0)
        {
            score.SendMessage("killed");
            Destroy(this.gameObject);
        }
		
	}
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "bullet")
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
