#region Librairies
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#endregion

public class LoadNextSecene : MonoBehaviour
{
    #region Variables
    #endregion

    #region Methods
    void Start ()
    {
        Invoke("LoadNextScene", 3f);        
	}
	
    private void LoadNextScene()
    {
        SceneManager.LoadScene("Main");
    }
    #endregion

}
