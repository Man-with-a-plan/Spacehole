using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
//using static System.Net.Mime.MediaTypeNames;

public class Boss : MonoBehaviour
{
    public Vector3 rotation;
    public float health = 50;
    public float maxHealth = 50;
    public Image healthBar;
    public GameObject explosionPrefab;
    public GameObject blackhole;
    [SerializeField] private GameObject littleshit;
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = health;
        healthBar = GameObject.FindGameObjectsWithTag("HealthBar")[0].GetComponent<Image>();
        littleshit = GameObject.FindWithTag("Player");


    }

    // Update is called once per frame
    void Update()
    {

        healthBar.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1);


    }
   
    private void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.tag == "bullet")
        {
            health--;
          
            if (health <= 0)
            {
               
                Instantiate(explosionPrefab, transform.position, Quaternion.identity);
                Destroy(collision.gameObject);
                Destroy(gameObject);
                BossManager.BossDestroyed();
            }

            
        }

        if (collision.gameObject == littleshit)
        {
            BossManager.Suckedin();
        }
      

    }
   
}
