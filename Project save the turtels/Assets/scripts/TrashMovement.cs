using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    private void Awake()
    {

        //geef het een random rotation
        transform.Rotate(0.0f, 0.0f, Random.Range(0.0f, 360f));
    }
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        // move the trash
        Vector2 Movement = new Vector2(Random.Range(-1, 2), Random.Range(-1, 2));
        rb.AddForce(Movement);
    }
}
