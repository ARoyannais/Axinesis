using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    public static float timeLeft = 5.0f;
    public GameObject Forme;
    public GameObject Checkpoint;
    int select_sprite;
    public GameObject deer;
    public GameObject bird;
    public GameObject squirel;

    // Use this for initialization
    void Start(){
        Checkpoint = GameObject.Find("Checkpoint");
        //SpriteRenderer renderer = this.GetComponent<SpriteRenderer>();
        //renderer.sprite = new Sprite();
        deer = GameObject.Find("deer1");
        bird = GameObject.Find("bird1");
        squirel = GameObject.Find("squirel1");
    }
	// Update is called once per frame
	void Update () {

    timeLeft -= Time.deltaTime;
    if (timeLeft < 0) {
        Spawning();
        timeLeft = 5.0f;
        //switch(Global_manager.)
        
        }
    }

    void Spawning() {
        select_sprite = Random.Range(1, 4);
        switch (select_sprite){
            case 1:
                this.GetComponent<SpriteRenderer>().sprite = deer.GetComponent<SpriteRenderer>().sprite;
                break;
            case 2:
                this.GetComponent<SpriteRenderer>().sprite = bird.GetComponent<SpriteRenderer>().sprite;
                break;
            case 3:
                this.GetComponent<SpriteRenderer>().sprite = squirel.GetComponent<SpriteRenderer>().sprite;
                break;
        }
        Vector2 collisionSize = this.GetComponent<SpriteRenderer>().sprite.bounds.size;
        this.GetComponent<BoxCollider2D>().size = collisionSize;
        //this.GetComponent<BoxCollider2D>().offset = new Vector2((collisionSize.x/2),0);
        transform.position = new Vector3(Random.Range(-5.5f, 5.5f), Random.Range(-3.5f, 3.5f), -1);
        //Global_manager.ihm.SetTarget(this.transform.position);
        Debug.Log(select_sprite);
    }

    private void OnMouseEnter(){
        timeLeft = 30.0f;
        Forme = GameObject.Find("Form_square");
        Forme.transform.position = this.transform.position;
        //Checkpoint.transform.position = Vector3(Forme.transform.position.x - Forme.transform.);
    }
}
