using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class GrotenTrashcann : MonoBehaviour
{
    public int afvalerin;
    
    private AudioSource ADS;

    private SpriteRenderer Srenders;
    public Sprite[] _sprite;
    private void Awake()
    {
        ADS = GetComponent<AudioSource>();
        Srenders = GetComponent<SpriteRenderer>();
        
    }
    private void Start()
    {
        Srenders.sprite = _sprite[0];
    }

    private void Update()
    {
        if(afvalerin == 20)
        {
            Srenders.sprite = _sprite[1];
        }
        if (afvalerin == 40)
        {
            Srenders.sprite = _sprite[2];
        }
        if (afvalerin == 60)
        {
            Srenders.sprite = _sprite[3];
        }
        if (afvalerin == 80)
        {
            Srenders.sprite = _sprite[4];
        }
        if (afvalerin == 100)
        {
            Srenders.sprite = _sprite[5];
        }

       
    }
    public void addtrash()
    {
        ADS.Play();
        afvalerin++;
    }
}
