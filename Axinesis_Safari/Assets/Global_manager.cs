using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Global_manager : MonoBehaviour {

    public Enum difficulty;
    public static GeneralParameters generalParams;
    public static IhmCommunicator ihm;
    public static int zoom;
    public static int score;
    public GameObject bg;
    public Text text_display;

    // Use this for initialization
    void Start () {
        generalParams = GetComponent<GeneralParameters>();
        if (generalParams.ConfigurationIsLoaded){
            difficulty = GetComponent<GeneralParameters>().Difficulty;
            zoom = GetComponent<GeneralParameters>().Zoom;
        }
        score = 0;
    }
	
	// Update is called once per frame
	void Update () {
        text_display.text = "Score : " + score.ToString();
        if(score > 500)
        {
            bg.GetComponent<SpriteRenderer>().color = Color.blue;
        }
    }
}
