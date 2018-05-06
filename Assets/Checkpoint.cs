using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {

    public static GameObject forme;
    public GameObject popUp;
    public static int stage;
    PointData ihmTarget;
    List<PointData> ihmList;

	// Use this for initialization
	void Start () {
        stage = 0;
	}

    // Update is called once per frame
    void Update()
    {
        if (Spawn.chooseForm == 1)
        {
            switch (stage)
            {
                case 1:
                    transform.position = PlacementCheckpoint('-', '-');
                    //TODO : list de points pour la trajectoire

                    //distance[0] = new PointData(1, target_position.x);
                    //Global_manager.ihm.SetTrajectory();
                    break;
                case 2:
                    transform.position = PlacementCheckpoint('-', '+');
                    //Global_manager.ihm.SetTarget(target_position);
                    break;
                case 3:
                    transform.position = PlacementCheckpoint('+', '+');
                    //Global_manager.ihm.SetTarget(target_position);
                    break;

                case 4:
                    transform.position = PlacementCheckpoint('+', '-');
                    //Global_manager.ihm.SetTarget(target_position);
                    break;
                case 5:
                    forme.transform.position = new Vector3(-100, 0, 1);
                    transform.position = new Vector3(-100, 0, 1);
                    Global_manager.score += stage * 10;
                    stage = 0;
                    Spawn.timeLeft = 0.0f;
                    break;
                default:
                    transform.position = PlacementCheckpoint('-', '-');
                    //Global_manager.ihm.SetTarget(target_position);
                    break;

            }

        }
        else if (Spawn.chooseForm == 2)
        {
            //placement checkpoint étoile
            if (stage <= 10)
            {
                transform.position = forme.transform.Find(stage.ToString()).position;
            }else{
                transform.position = new Vector3(-10, -10, 0);
                forme.transform.position = new Vector3(-10, -10, 0);
                Global_manager.score += stage * 10;
                stage = 0;
                Spawn.timeLeft = 0.0f;
            }
        }
        //placement checkpoint Octogone
        else if (Spawn.chooseForm == 3)
        {
            if (stage <= 8)
            {
                transform.position = forme.transform.Find(stage.ToString()).position;
                /* TODO -- Problèmes pour comprendre List<List<Pointdata>>
                 * ihmTarget.Xd = transform.position.x;
                 * ihmTarget.Yd = transform.position.y;
                 * ihmList.Add(ihmTarget);
                 * Global_manager.ihm.SetTrajectory(ihmList);
                */
            }
            else
            {
                transform.position = new Vector3(-10, -10, 0);
                forme.transform.position = new Vector3(-10, -10, 0);
                Global_manager.score += stage * 10;
                stage = 0;
                Spawn.timeLeft = 0.0f;
            }
        }
    }

    //Fonction de placement du checkpoint (seulement pour le carré)
    private Vector3 PlacementCheckpoint(char signe1, char signe2){
        Vector3 temp = new Vector3();
        
        if ((int)signe1 == '+'){
            temp.x = (popUp.transform.position.x + forme.GetComponent<BoxCollider2D>().bounds.size.x / 2);
        }
        else if ((int)signe1 == '-'){
            temp.x = (popUp.transform.position.x - forme.GetComponent<BoxCollider2D>().bounds.size.x / 2);
        }

        if ((int)signe2 == '+'){
            temp.y = (popUp.transform.position.y + forme.GetComponent<BoxCollider2D>().bounds.size.y / 2);
        }
        else if ((int)signe2 == '-'){
            temp.y = (popUp.transform.position.y - forme.GetComponent<BoxCollider2D>().bounds.size.y / 2);
        }
        temp.z = -9;
        return temp;
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "cursor"){
            stage += 1;
        }
    }
}
