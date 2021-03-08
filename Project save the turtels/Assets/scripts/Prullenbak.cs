using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Prullenbak : MonoBehaviour
{
    public int stufInprullenBak;
    public int fullPrullebakInt;

    public int prullenBakNummer;

    bool isvol = false;

    public bool legen = false;

    public float time = 0.3f;

    public GrotenTrashcann bigtrash;

    private AudioSource adS;

    public Sprite[] sp;

    private SpriteRenderer sprenders;

    private void Awake()
    {
        adS = GetComponent<AudioSource>();
        sprenders = GetComponent<SpriteRenderer>();
        sprenders.sprite = sp[0];
    }

    public void AddPrull()
    {
        // add een trash in de prullenbak
        stufInprullenBak++;
        adS.Play();
    }
    private void FixedUpdate()
    {
        //change the sprite of the trashcan
        if (stufInprullenBak >  1)
        {
            sprenders.sprite = sp[1];
        }
        if(stufInprullenBak > 14)
        {
            sprenders.sprite = sp[2];
        }
        if(stufInprullenBak > 19)
        {
            sprenders.sprite = sp[3];
        }

        if(stufInprullenBak ==  0)
        {
            sprenders.sprite = sp[0];
        }
       
        // looking if the trashcan is still full
        if(stufInprullenBak < fullPrullebakInt)
        {
            isvol = false;
        }
       
        if (stufInprullenBak >= fullPrullebakInt)
        {
            Prullebakvol();
        }
        if (isvol == true)
        {
            //print("o ja ");
        }
        // empty the trashcan
        if(legen == true)
        {
            if (stufInprullenBak > 0)
            {
                time -= Time.deltaTime;
                if (time < 0)
                {
                    stufInprullenBak--;
                    bigtrash.addtrash();
                    time = 0.3f;
                }
                //change the sprite so it is empty
                if (stufInprullenBak == 20)
                {
                    sprenders.sprite = sp[2];
                }

                if (stufInprullenBak == 14)
                {
                    sprenders.sprite = sp[1];
                }
                if (stufInprullenBak == 1)
                {
                    sprenders.sprite = sp[0];
                }
            }
        }
    }
    public void turtel_no()
    {
        // if the trashcan touches a turtel empty the trashcan
        stufInprullenBak = 0;
        sprenders.sprite = sp[0];
    }
    /// <summary>
    /// call when the prullenbak has 20 pieces of trash in it
    /// </summary>
    public void Prullebakvol()  
    {
        isvol = true;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        // find the good big trashcan.
        if(prullenBakNummer == 1)
        {
            if (collision.CompareTag("btc1"))
            {
                legen = true;
            }
        }
        if(prullenBakNummer == 2)
        {
            if (collision.CompareTag("btc2"))
            {
                legen = true;
            }
        }
        if(prullenBakNummer == 3)
        {
            if (collision.CompareTag("btc3"))
            {
                legen = true;
            }
        }
        if(prullenBakNummer == 4)
        {
            if (collision.CompareTag("btc4"))
            {
                legen = true;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        //not on the bigtrash can anymore
        legen = false;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(isvol == false)
        {
            //add prull
            if (other.CompareTag("trash"))
            {
                AddPrull();
                Destroy(other.gameObject);
            }
        }
        //emety te trashcan if it comes in contect with a turtle
        if (other.CompareTag("turtel"))
        {
            turtel_no();
            Destroy(other.gameObject);
        }
        
    }


}
