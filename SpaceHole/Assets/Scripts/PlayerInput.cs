using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerInput : MonoBehaviour
{
    [SerializeField] public Ship ship;
    [SerializeField] public float shipSpeed;
    private void Update()
    {
        var horizontal = UnityEngine.Input.GetAxis("Horizontal");
        var vertical = UnityEngine.Input.GetAxis("Vertical");
        var offset = new Vector3(horizontal, vertical, 0) * shipSpeed * Time.deltaTime;
       
     
        ship.transform.position += offset;

        if (UnityEngine.Input.GetKeyUp(KeyCode.Space))
        {
            ship.FireProjectile();
        }
    }
}