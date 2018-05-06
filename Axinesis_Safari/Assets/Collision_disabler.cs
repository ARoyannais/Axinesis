using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_disabler : MonoBehaviour {

    // Use this for initialization
    public GameObject Animal;
	void Start () {
        Animal = GameObject.Find("PopUp");
	}
	
	// Update is called once per frame
	void Update () {
        if (Checkpoint.stage > 0){
            Physics2D.IgnoreCollision(this.GetComponent<CircleCollider2D>(), Animal.GetComponent<BoxCollider2D>(),true);
        }else{
            Physics2D.IgnoreCollision(this.GetComponent<CircleCollider2D>(), Animal.GetComponent<BoxCollider2D>(), false);
        }
    }
}
