//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Checkpoint_Manager : MonoBehaviour
//{
//    public GameObject checkpoint_loc;
//    public GameObject forme;
//    //public static int stage;
//    public Vector3 target_position;
//    //PointData[] distance;

//    // Use this for initialization
//    void Start(){
//        //stage = 0;
        
//    }

//    // Update is called once per frame
//    void Update(){

//        if(Spawn.chooseForm == 1) {
//            switch (stage)
//            {
//                case 1:
//                    checkpoint_loc.transform.position = PlacementCheckpoint('+', '+');
//                    //Debug.Log("test " + checkpoint_loc.transform.position);
//                    //target_position = new Vector3((transform.position.x - GetComponent<BoxCollider2D>().bounds.size.x / 2), (transform.position.y + GetComponent<BoxCollider2D>().bounds.size.y / 2), -1);
//                    //checkpoint_loc.transform.position = target_position;

//                    //TODO : list de points pour la trajectoire

//                    //distance[0] = new PointData(1, target_position.x);
//                    //Global_manager.ihm.SetTrajectory();
//                    break;
//                case 2:
//                    checkpoint_loc.transform.position = PlacementCheckpoint('-', '+');
//                    //Debug.Log("test " + checkpoint_loc.transform.position);
//                    //target_position = new Vector3((transform.position.x + GetComponent<BoxCollider2D>().bounds.size.x / 2), (transform.position.y + GetComponent<BoxCollider2D>().bounds.size.y / 2), -1);
//                    //checkpoint_loc.transform.position = target_position;
//                    //Global_manager.ihm.SetTarget(target_position);
//                    break;
//                case 3:
//                    checkpoint_loc.transform.position = PlacementCheckpoint('-', '-');
//                    //Debug.Log("test " + checkpoint_loc.transform.position);
//                    //target_position = new Vector3((transform.position.x + GetComponent<BoxCollider2D>().bounds.size.x / 2), (transform.position.y - GetComponent<BoxCollider2D>().bounds.size.y / 2), -1);
//                    //checkpoint_loc.transform.position = target_position;
//                    //Global_manager.ihm.SetTarget(target_position);
//                    break;
//                case 4:
//                    stage = 0;
//                    checkpoint.stage_Update = 0;
//                    Spawn.timeLeft = 0.0f;
//                    checkpoint_loc.transform.position = new Vector3(-100, 0, 1);
//                    forme.transform.position = new Vector3(-100, 0, 1);
//                    break;
//                default:
//                    checkpoint_loc.transform.position = PlacementCheckpoint('+', '-');
//                    //target_position = new Vector3((transform.position.x - GetComponent<BoxCollider2D>().bounds.size.x / 2), (transform.position.y - GetComponent<BoxCollider2D>().bounds.size.y / 2), -1);
//                    //checkpoint_loc.transform.position = target_position;
//                    //Global_manager.ihm.SetTarget(target_position);
//                    break;
//            }
//        }
//        else if (Spawn.chooseForm == 2) {
//            switch (stage){
//                case 1:

//                    break;

//            }
//        }
//    }
    

//    private Vector3 PlacementCheckpoint(char signe1, char signe2){
//        Vector3 temp = new Vector3();
//        if((int) signe1 == '+'){
//            //Debug.Log("in+1");
//            //Debug.Log("transform.position.x = " + transform.position.x);
//            temp.x = (transform.position.x + forme.GetComponent<BoxCollider2D>().bounds.size.x / 2);
//        }else if ((int)signe1 == '-'){
//            //Debug.Log("in-1");
//            //Debug.Log("transform.position.x = " + transform.position.x);
//            temp.x = (transform.position.x - forme.GetComponent<BoxCollider2D>().bounds.size.x / 2);
//        }

//        if ((int)signe2 == '+'){
//            //Debug.Log("in+2");
//            //Debug.Log("transform.position.y = " + transform.position.y);
//            temp.y = (transform.position.y + forme.GetComponent<BoxCollider2D>().bounds.size.y / 2);
//        }
//        else if ((int)signe2 == '-'){
//            //Debug.Log("in-2");
//            //Debug.Log("transform.position.y = " + transform.position.y);
//            temp.y = (transform.position.y - forme.GetComponent<BoxCollider2D>().bounds.size.y / 2);
//        }
//        temp.z = -9;
//        //Debug.Log(" temp coor " +temp.x + " " + temp.y);
//        return temp;
//    }
//}