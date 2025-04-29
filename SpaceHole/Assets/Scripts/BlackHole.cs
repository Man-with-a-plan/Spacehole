using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Analytics;

public class BlackHole : MonoBehaviour
{
    public bool destroy;
    public Transform player;
    public GameisOver gameover2;
    public Rigidbody playerBody;
    public Transform Enemyies;
    public Rigidbody EnemyBody;
    public float influenceRange;
    public float intensity;
    public float distanceToPlayer;
    public float distanceToEnemy;
    Vector3 targetScale;
    [SerializeField] public Boss boss;
    Vector2 pullForce;


    public Vector3 rotation;



    private Vector3 originalScale; // Store the initial scale
    public float scaleMultiplier = 1.5f; // How much bigger it should grow
    public float growDuration = 1f; // Time to grow
    public float shrinkDuration = 1f; // Time to shrink
    public float waitTime = 5f; // Time before shrinking


    void Start()
    {
        if(playerBody == null)
        {
            playerBody = GameObject.FindWithTag("Player").GetComponent<Rigidbody>();
            player = GameObject.FindWithTag("Player").GetComponent<Transform>();
        }
        originalScale = transform.localScale; // Save the initial scale
        targetScale = originalScale * scaleMultiplier;
      
        StartCoroutine(GrowAndShrinkObject());

    }
   
    IEnumerator GrowAndShrinkObject()
    {
        
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            if (destroy == true)
            {
                Destroy(gameObject);
            }
            yield return ScaleObject(originalScale, targetScale, growDuration); 
            yield return influenceRange = influenceRange * scaleMultiplier;
            yield return new WaitForSeconds(waitTime);
            yield return influenceRange = influenceRange / scaleMultiplier;
            yield return ScaleObject(targetScale, originalScale, shrinkDuration); // Shrink back}
        }
    }

    IEnumerator ScaleObject(Vector3 from, Vector3 to, float duration)
    {

        float time = 0f;
        while (time < duration)
        {
            transform.localScale = Vector3.Lerp(from, to, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        transform.localScale = to; // Ensure it reaches the exact target scale
    }

    // Update is called once per frame
    void Update()
    {
        

        this.transform.Rotate(rotation * 1 * Time.deltaTime);

        distanceToPlayer = Vector3.Distance(player.position, transform.position);
        if (distanceToPlayer <= influenceRange)
        {
         
            pullForce = (transform.position - player.position).normalized / distanceToPlayer * intensity;
            playerBody.AddForce(pullForce, ForceMode.Force);
        }
        


    }
    private void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.tag == "ship") 
        {

            
            Destroy(collision.gameObject);
          
        }

    }

    }