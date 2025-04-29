using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attractionofEnemy : MonoBehaviour
{

    public float attractionspeed = 10;
    public GameObject hole;
    public GameObject sheeee;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sheeee.transform.position = Vector3.MoveTowards(sheeee.transform.position, hole.transform.position, attractionspeed);

    }
}
