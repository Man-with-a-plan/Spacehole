using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SocialPlatforms;

public class Ship : MonoBehaviour
{

    //[SerializeField] public float shipSpeed;
   public GameObject projectilePrefab;
    public GameisOver apatsuapatsu;
    
    public float ShipSpeed = 10;

   
    private void Update()
    {
       
    }
    public void FireProjectile()
    {
        Instantiate(projectilePrefab, transform.position, transform.rotation);
    }
  
}
