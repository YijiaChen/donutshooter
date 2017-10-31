using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour {
    private int points;
    public TextMesh scorer;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void killed()
    {   
        points += 1;
        scorer.text = points.ToString();
    }
}
