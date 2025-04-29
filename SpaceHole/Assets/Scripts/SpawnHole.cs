using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHole : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private GameObject Holeprefab;
    [SerializeField] private int yaxis;
    [SerializeField] private Transform holeSpawn;
    private GameObject Holeinstance;
    private int enemyCount;

  [SerializeField] private float interval = 3;
    void Start()
    {

       StartCoroutine( spawnEnemy(interval, Holeprefab));
    }
    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
       Instantiate(enemy, transform.position, transform.rotation);

  
  


    }

    private void OnDisable()
    {
        if (Holeinstance == null)
            return;

        Destroy(Holeinstance.gameObject);
        Holeinstance = null;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
