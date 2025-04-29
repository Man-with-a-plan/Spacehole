using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameisOver : MonoBehaviour

{
    public void Setup()
    {
        gameObject.SetActive(true);

    }
    public void RestartButton()
    {
        Time.timeScale = 1;
        Debug.Log("youagain?whatalooser");
        SceneManager.LoadScene("SpaceInvadersBlackhole 1");

    }
    public void RestartbossBattle()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Blackhole");
    }
     
}
