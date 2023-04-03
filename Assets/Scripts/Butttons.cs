using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Butttons : MonoBehaviour
{
    // Buttons manager
    
    

    public void GoToScene(int sceneIDX)
   {
        SceneManager.LoadScene(sceneIDX);
   }
}

