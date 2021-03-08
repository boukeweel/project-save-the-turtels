using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashSpawner : MonoBehaviour
{
    public List<GameObject> trash;

    public float spawntime;
    int x_pos;
    int y_pos;

    int randomDing;
    

    private void Start()
    {

        spawntime = Random.Range(1, 2);
    }
    private void Update()
    {
        spawntime -= Time.deltaTime;
        
        
        if(spawntime < 0)
        {
            //spawn trash op random location
            randomDing = Random.Range(0, 7);
            x_pos = Random.Range(-17, 15);
            y_pos = Random.Range(-8, 8);
            Vector3 plaats = new Vector3(x_pos, y_pos,-1);
            Instantiate(trash[randomDing], plaats, Quaternion.identity);
            spawntime = Random.Range(1, 3);
        }
    }
}
