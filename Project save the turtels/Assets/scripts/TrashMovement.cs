using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Vector2 Movement = new Vector2(Random.Range(-1, 2), Random.Range(-1, 2));
        rb.AddForce(Movement);
    }
}
