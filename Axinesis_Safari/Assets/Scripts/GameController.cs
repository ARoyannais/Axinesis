#region Librairies
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#endregion Properties

public class GameController : MonoBehaviour
{
    #region Variables
    private IhmCommunicator ihmCommunicator;
    #endregion

    #region Methods
    void Awake()
    {
        ihmCommunicator = FindObjectOfType<IhmCommunicator>();      
    }

    void Start()
    {
        if(ihmCommunicator)
        {           
            ihmCommunicator.StartOrStopRobot(true);
            ihmCommunicator.LevelStarted("HelloWorld");
            ihmCommunicator.SetFreeTraj();
        }        
    }
    #endregion
}
