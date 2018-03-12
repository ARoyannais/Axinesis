using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour {

    public GameObject square;
    public static int stage_Update;

	// Use this for initialization
	void Start () {
        square = GameObject.Find("Form_square");
        stage_Update = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseEnter(){
        stage_Update += 1;
        Checkpoint_Manager.stage = stage_Update;
        Debug.Log(stage_Update + " " + Checkpoint_Manager.stage);
    }
}
