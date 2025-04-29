using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.UI;
public class PlayerLives : MonoBehaviour
{

    public int lives = 3;
    private bool isPaused;
    public Image [] livesUI;
    public GameObject explosionPrefab;
    public GameisOver gameover;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.tag == "ship")
        {
            Debug.Log("Game!");
            Destroy(collision.collider.gameObject);
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            lives -= 1;

            for(int i = 0; i<livesUI.Length; i++)
            {
                if (i < lives)
                {
                    livesUI[i].enabled = true;
                }
                else
                {
                    livesUI[i].enabled = false;
                }
            }
            if (lives <= 0)
            {
                Time.timeScale = 0;
                gameover.Setup();
                Destroy(gameObject);

            }
        }
       
        
    }
}
