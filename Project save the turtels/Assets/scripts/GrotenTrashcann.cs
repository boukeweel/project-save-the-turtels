using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class GrotenTrashcann : MonoBehaviour
{
    public int afvalErIn;
    
    private AudioSource ads;

    private SpriteRenderer Srenders;
    public Sprite[] _sprite;
    private void Awake()
    {
        ads = GetComponent<AudioSource>();
        Srenders = GetComponent<SpriteRenderer>(); 
    }
    private void Start()
    {
        Srenders.sprite = _sprite[0];
    }

    private void Update()
    {
        //verander de sprite van de grote trash cann
        if(afvalErIn == 20)
        {
            Srenders.sprite = _sprite[1];
        }
        if (afvalErIn == 40)
        {
            Srenders.sprite = _sprite[2];
        }
        if (afvalErIn == 60)
        {
            Srenders.sprite = _sprite[3];
        }
        if (afvalErIn == 80)
        {
            Srenders.sprite = _sprite[4];
        }
        if (afvalErIn == 100)
        {
            Srenders.sprite = _sprite[5];
        }
    }
    public void addtrash()
    {
        //add trash and play sound
        ads.Play();
        afvalErIn++;
    }
}
