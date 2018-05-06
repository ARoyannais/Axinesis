using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public static float timeLeft = 1f;
    public GameObject square;
    public GameObject star;
    public GameObject octo;
    public GameObject checkpoint;
    int select_sprite;
    public GameObject deer;
    public GameObject bird;
    public GameObject squirel;
    public static int chooseForm;

    // Use this for initialization
    void Start()
    {
        //Checkpoint = GameObject.Find("Checkpoint");
        SpriteRenderer renderer = this.GetComponent<SpriteRenderer>();
        renderer.sprite = new Sprite();
    }
    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0){
            Spawning();
            timeLeft = 0.1f;
        }
    }

    void Spawning(){
        select_sprite = Random.Range(1, 4);
        switch (select_sprite)
        {
            case 1:
                GetComponent<SpriteRenderer>().sprite = deer.GetComponent<SpriteRenderer>().sprite;
                break;
            case 2:
                GetComponent<SpriteRenderer>().sprite = bird.GetComponent<SpriteRenderer>().sprite;
                break;
            case 3:
                GetComponent<SpriteRenderer>().sprite = squirel.GetComponent<SpriteRenderer>().sprite;
                break;
        }
        Vector2 collisionSize = GetComponent<SpriteRenderer>().sprite.bounds.size;
        GetComponent<BoxCollider2D>().size = collisionSize;
        transform.position = new Vector3(Random.Range(-7.5f, 7.5f)*(Global_manager.zoom/100), Random.Range(-3.5f, 3.5f)*(Global_manager.zoom/100), -9);
        Checkpoint.stage = 0;
        GetComponent<ParticleSystem>().Play();
        
        //Bug : comportement bizarre. object reference not set to an instance of an object
        //Global_manager.ihm.SetTarget(transform.position);
    }

    public void OnCollisionEnter2D(Collision2D collision){
        
        if (collision.gameObject.tag == "cursor"){
            chooseForm = Random.Range(1,4);
            timeLeft = 30.0f;
            switch (chooseForm){
                case 1:
                    square.transform.position = transform.position;
                    Checkpoint.forme = square;
                    break;
                case 2:
                    star.transform.position = transform.position;
                    Checkpoint.forme = star;
                    break;
                case 3:
                    octo.transform.position = transform.position;
                    Checkpoint.forme = octo;
                    break;
                default:
                    square.transform.position = transform.position;
                    Checkpoint.forme = square;
                    Debug.Log("chooseForm switch OOB");
                    break; 
            }
            Checkpoint.stage = 1;
        }
    }
}