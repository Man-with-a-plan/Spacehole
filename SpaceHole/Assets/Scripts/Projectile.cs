using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Projectile : MonoBehaviour
{
    // Start is called before the first frame update
    public float Speed;
    public GameObject explosionPrefab;
    public GameObject[] shipsleft;
    public int shipss = 12;
    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + transform.right * Speed * Time.deltaTime;

    }
         void OnTriggerEnter(Collider collision)
        {



            if (collision.gameObject.tag == "ship")
            {

                Instantiate(explosionPrefab, transform.position, Quaternion.identity);
                Destroy(collision.gameObject);
                Destroy(gameObject);
                //Scenecontroller bobby;
            }

            if (collision.gameObject.tag == "Boundary")
            {
                Destroy(gameObject);

            }
        }
    
}
