using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class Global_manager : MonoBehaviour {

    public int difficulty;
    public static GeneralParameters generalParams;
    public static IhmCommunicator ihm;

    // Use this for initialization
    void Start () {

        if (generalParams.ConfigurationIsLoaded){
            difficulty = Convert.ToInt32(generalParams.Difficulty);
            Debug.Log(difficulty);
        }
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
