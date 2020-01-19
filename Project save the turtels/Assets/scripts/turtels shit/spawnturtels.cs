using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnturtels : MonoBehaviour
{
    public GameObject turtel;
    public int min_x_pos;
    public int max_x_pos;
    public int min_y_pos;
    public int Max_y_pos;
    private int x_pos;
    private int y_pos;

    private float spawntimer;

    private void Start()
    {
        spawntimer = Random.Range(5, 10);
    }
    private void Update()
    {
        spawntimer -= Time.deltaTime;

        if(spawntimer < 0)
        {
            x_pos = Random.Range(min_x_pos, max_x_pos);
            y_pos = Random.Range(min_y_pos, Max_y_pos);
            Vector3 plaats = new Vector3(x_pos, y_pos, 0);
            Instantiate(turtel, plaats, Quaternion.identity);
            spawntimer = Random.Range(5, 10);
        }
    }
}
