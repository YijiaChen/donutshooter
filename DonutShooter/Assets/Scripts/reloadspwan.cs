using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reloadspwan : MonoBehaviour {
    public int spawnRate;
    private float spawnTimer;
    private int chancer;
    public GameObject reload1;
    public GameObject reload2;
    public GameObject reload3;


	// Use this for initialization
	void Start () {     
		
	}
	
	// Update is called once per frame
	void Update () {
        spawnTimer += 1;
        if (spawnTimer % spawnRate == 0)
        {
            chancer = Random.Range(0, 301);
            if (chancer <= 100)
            {
                Instantiate(reload1, transform.position, Quaternion.identity);

            }
            if (chancer <= 200 && chancer > 100)
            {
                Instantiate(reload2, transform.position, Quaternion.identity);

            }
            if (chancer<=300 && chancer > 200)
            {
                Instantiate(reload3, transform.position, Quaternion.identity);

            }
        }

        
	}
}
