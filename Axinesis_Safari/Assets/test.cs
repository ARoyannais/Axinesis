using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("enter Trig");
    
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("enter Coll");
    }
}
