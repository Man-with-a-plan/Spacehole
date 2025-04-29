using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;

public class Shipmove : MonoBehaviour
{
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Game Started!");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right  * moveSpeed * Time.deltaTime);
    }
     void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("Boundary"))
        {
            // Debug.Log("Game Started!");
            transform.position = new Vector3(transform.position.x, transform.position.y - 3, transform.position.z);
            moveSpeed = -moveSpeed;

        }
    }
}
