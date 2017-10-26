using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie : MonoBehaviour {
    public int hitpoints;
    public TextMesh hittext;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        hittext.text = hitpoints.ToString();
        if (hitpoints <= 0)
        {
           
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

    }
}
