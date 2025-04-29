using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BossManager : MonoBehaviour
{
    public static event Action OnBossDestroyed;
    public static event Action OnPlayerSucked;
    public EndGame goodbye;
    public GameisOver tryagain;
    public static void BossDestroyed()
    {
        if (OnBossDestroyed != null)
        {
            OnBossDestroyed.Invoke();
        }
    }

    public static void Suckedin()
    {
        if (OnPlayerSucked != null)
        {
            OnPlayerSucked.Invoke();
        }
    }
    void OnEnable()
    {
        BossManager.OnBossDestroyed += RespondToBossDeath;
        BossManager.OnPlayerSucked += RespondToPlayerDeath;
    }

    void OnDisable()
    {
        BossManager.OnBossDestroyed -= RespondToBossDeath;
        BossManager.OnPlayerSucked -= RespondToPlayerDeath;
    }

    void RespondToBossDeath()
    {
        Time.timeScale = 0;
        goodbye.Setup();
    }

   void RespondToPlayerDeath()
    {
        Time.timeScale = 0;
        tryagain.Setup();
    }
}
