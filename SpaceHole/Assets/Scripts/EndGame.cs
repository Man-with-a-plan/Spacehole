using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndGame : MonoBehaviour
{
    // Start is called before the first frame update
    public void Setup()
    {
        gameObject.SetActive(true);
        Debug.Log("d;kfjadj");
    }
    public void RestartButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SpaceInvadersBlackhole 1");

    }
}
