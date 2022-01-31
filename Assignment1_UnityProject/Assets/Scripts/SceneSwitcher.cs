using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    //switches the scenes
    void Update()
    {
        if (Input.GetKey(KeyCode.Backspace))
        {
            SceneManager.LoadScene("Assignment1_Scene2", LoadSceneMode.Single);
        }
        if (Input.GetKey(KeyCode.End))
        {
            SceneManager.LoadScene("Assignment1", LoadSceneMode.Single);
        }
    }
}
