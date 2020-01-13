using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{

    public Transform Trash1,Trash2,Trash3, Trash4;
    public float timeTillTrashcan;



    public float speed = 1.0F;

    private float startTime;

    private float distCovered;

    private bool prul1, prul2, prul3, prul4 = false;

    private float journeyLength;

    private float _speed = 1;

    public Rigidbody2D rb;
   

    
    private void Start()
    {
        startTime = Time.time;

        rb = GetComponent<Rigidbody2D>();

    }
    private void FixedUpdate()
    {
        Vector2 Movement = new Vector2(Random.Range(-1, 1), Random.Range(-1, 1));
        rb.AddForce(Movement);
    }
    private void Update()
    {

        transform.Translate(4 * speed * Time.deltaTime, 3 * speed * Time.deltaTime, 0);

         distCovered = (Time.time - startTime) * speed;
        if(prul1 == true)
        {
            distCovered = (Time.time - startTime) * speed;
            float fractionOfJourney = distCovered / journeyLength;
            journeyLength = Vector3.Distance(transform.position, Trash1.position);


            transform.position = Vector3.Lerp(transform.position, Trash1.position, fractionOfJourney);
        }
        if(prul2 == true)
        {
            distCovered = (Time.time - startTime) * speed;
            float fractionOfJourney = distCovered / journeyLength;
            journeyLength = Vector3.Distance(transform.position, Trash2.position);

            transform.position = Vector3.Lerp(transform.position, Trash2.position, fractionOfJourney);
        }
        if(prul3 == true)
        {
            distCovered = (Time.time - startTime) * speed;
            float fractionOfJourney = distCovered / journeyLength;
            journeyLength = Vector3.Distance(transform.position, Trash3.position);

            transform.position = Vector3.Lerp(transform.position, Trash3.position, fractionOfJourney);
        }
        if(prul4 == true)
        {
            distCovered = (Time.time - startTime) * speed;
            float fractionOfJourney = distCovered / journeyLength;
            journeyLength = Vector3.Distance(transform.position, Trash4.position);

            transform.position = Vector3.Lerp(transform.position, Trash4.position, fractionOfJourney);
        }
       
    }
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Trash1"))
        {
            prul1 = true;
        }
        if (collision.CompareTag("Trash2"))
        {
            prul2 = true;
        }
        if (collision.CompareTag("Trash3"))
        {
            prul3 = true;
        }
        if (collision.CompareTag("Trash4"))
        {
            prul4 = true;
        }
       
    }
   
    private void OnTriggerExit(Collider other)
    {
        
    }
}
