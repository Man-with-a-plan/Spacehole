using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyManager : MonoBehaviour
{
    public int enemyCount;
    public GameObject theFirst;
    private void Start()
    {
        
        
    }
    void Update()
    {
       
        
    }

    public void EnemyKilled()
    {
        enemyCount--;
        Debug.Log(enemyCount);
        if (enemyCount < 0)
        {
            
            SceneManager.LoadScene("Blackhole");
        }
    }

    
}
