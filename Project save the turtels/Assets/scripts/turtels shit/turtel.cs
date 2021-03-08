using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turtel : MonoBehaviour
{
    private Rigidbody2D rig;
    public int movement_x;
    public int movement_y;
    public Vector2 movement;
    public Vector3 rotation;
    private void Awake()
    {
        transform.Rotate(rotation);
    }

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        // move the turtles
        movement = new Vector2(movement_x, movement_y);
        rig.AddForce(movement);
    }

}
