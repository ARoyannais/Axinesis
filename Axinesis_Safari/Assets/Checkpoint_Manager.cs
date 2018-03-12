using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint_Manager : MonoBehaviour
{
    public GameObject checkpoint_loc;
    public GameObject forme;
    public static int stage;
    public Vector3 target_position;
    //public static GameObject globalManager;

    // Use this for initialization
    void Start()
    {
        forme = GameObject.Find("Form_square");
        checkpoint_loc = GameObject.Find("Checkpoint");
        stage = 0;
    }

    // Update is called once per frame
    void Update()
    {
       // print(stage);
        switch (stage){
            case 1:
                target_position = new Vector3((transform.position.x - GetComponent<BoxCollider2D>().bounds.size.x / 2), (transform.position.y + GetComponent<BoxCollider2D>().bounds.size.y / 2), -1);
                checkpoint_loc.transform.position = target_position;
                //Global_manager.ihm.SetTarget(target_position);
                break;
            case 2:
                target_position = new Vector3((transform.position.x + GetComponent<BoxCollider2D>().bounds.size.x / 2), (transform.position.y + GetComponent<BoxCollider2D>().bounds.size.y / 2), -1);
                checkpoint_loc.transform.position = target_position;
                //Global_manager.ihm.SetTarget(target_position);
                break;
            case 3:
                target_position = new Vector3((transform.position.x + GetComponent<BoxCollider2D>().bounds.size.x / 2), (transform.position.y - GetComponent<BoxCollider2D>().bounds.size.y / 2), -1);
                checkpoint_loc.transform.position = target_position;
                //Global_manager.ihm.SetTarget(target_position);
                break;
            case 4:
                stage = 0;
                checkpoint.stage_Update = 0;
                Spawn.timeLeft = 0.0f;
                checkpoint_loc.transform.position = new Vector3(-100, 0, 1);
                forme.transform.position = new Vector3(-100, 0, 1);
                break;
            default:
                target_position = new Vector3((transform.position.x - GetComponent<BoxCollider2D>().bounds.size.x / 2), (transform.position.y - GetComponent<BoxCollider2D>().bounds.size.y / 2), -1);
                checkpoint_loc.transform.position = target_position;
                //Global_manager.ihm.SetTarget(target_position);
                break;
        }
    }

}