using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashSpawner : MonoBehaviour
{
    public List<GameObject> trash;

    public float spawntime;
    int x_pos;
    int y_pos;

    private void Start()
    {

        spawntime = Random.Range(1, 2);
    }
    private void Update()
    {
        spawntime -= Time.deltaTime;
        
        
        if(spawntime < 0)
        {
            x_pos = Random.Range(-17, 15);
            y_pos = Random.Range(-8, 8);
            Vector2 plaats = new Vector2(x_pos, y_pos);
            Instantiate(trash[0], plaats, Quaternion.identity);
            spawntime = Random.Range(1, 3);
        }
    }
}
