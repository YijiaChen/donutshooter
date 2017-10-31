using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie_spawner : MonoBehaviour {
    public float spawnmaxy;
    public float spawnminy;
    public float spawnDis;
    public GameObject monster;
    public int spawnrate;
    private int spawntimer;
	// Use this for initialization
	void Start () {
        //initial enemies 
        Vector3 newpos = new Vector3(spawnDis, Random.Range(spawnminy, spawnmaxy), 0);
        Instantiate(monster, newpos, Quaternion.identity);
        Vector3 newpos2 = new Vector3(spawnDis, Random.Range(spawnminy, spawnmaxy), 0);
        Instantiate(monster, newpos2, Quaternion.identity);
        Vector3 newpos3 = new Vector3(spawnDis, Random.Range(spawnminy, spawnmaxy), 0);
        Instantiate(monster, newpos3, Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update () {
        spawntimer += 1;
        if (spawntimer % spawnrate == 0)
        {
            Vector3 newpos = new Vector3(spawnDis, Random.Range(spawnminy, spawnmaxy), 0);
            Instantiate(monster, newpos, Quaternion.identity);
        }
		
	}

}
