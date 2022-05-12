using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void GoToScene(string sceneName)
    {
        Debug.Log("pressed button"); //check button functionality
        SceneManager.LoadScene(sceneName); //load scene
    }

    public void Awake()
    {
        Cursor.visible = true; //set cursor to visible
    }
}