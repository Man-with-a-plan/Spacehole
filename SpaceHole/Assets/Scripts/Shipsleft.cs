using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shipsleft : MonoBehaviour
{
    // Start is called before the first frame update
   


    private EnemyManager enemyManager;

    void Start()
    {
        enemyManager = FindObjectOfType<EnemyManager>(); // Find the manager in the scene
    }

    void OnDestroy() // This triggers when the enemy is destroyed
    {
        if (enemyManager != null)
        {
            enemyManager.EnemyKilled();
        }
    }

}
