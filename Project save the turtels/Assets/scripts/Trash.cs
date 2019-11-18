using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    public Vector2 velocity;
    private Rigidbody2D rig2d;
    private void Start()
    {
        rig2d = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        velocity = new Vector2(5f, 5f);
        rig2d.MovePosition(rig2d.position + velocity * Time.deltaTime);
    }
}
