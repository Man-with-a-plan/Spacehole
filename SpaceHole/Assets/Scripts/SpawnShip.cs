using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class SpawnShip : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject shipPrefab;
    [SerializeField] private int yaxis;
    [SerializeField] private Transform shipSpawnPoint;
    private GameObject shipInstance;
    private int enemyCount;
    [SerializeField] private int waves;
    [SerializeField] private bool toWave;

    [SerializeField] private float swarmerInterval = 10;

    void Start()
    {
        if (toWave == true)
        {
            waves = int.MaxValue;
        }
        StartCoroutine(spawnEnemy(swarmerInterval, shipPrefab));
        enemyCount = GameObject.FindGameObjectsWithTag("ship").Length; // Count enemies at start
        Debug.Log(enemyCount);
    }



    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        while (waves>0)
        {

            GameObject newEnemy = Instantiate(enemy, transform.position, Quaternion.identity);

            yield return new WaitForSeconds(interval);
            waves--;
        }
        
    }
    private void OnDisable()
    {
        if (shipInstance == null)
            return;

        Destroy(shipInstance.gameObject);
        shipInstance = null;
    }
}
