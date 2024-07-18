using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("Main");
    }

    public void LoadProlog()
    {
        SceneManager.LoadScene("Prolog");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
