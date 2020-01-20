using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Prullenbak : MonoBehaviour
{
    public int stufinprullenbak;
    public int fullPrullebakint;

    public int Prullenbaknummer;

   

    bool isvol = false;

    public bool legen = false;

    public float time = 0.3f;

    public GrotenTrashcann Bigtrash;

    private AudioSource AdS;

    public Sprite[] sp;

    private SpriteRenderer sprenders;

    private void Awake()
    {
        AdS = GetComponent<AudioSource>();

        sprenders = GetComponent<SpriteRenderer>();

        sprenders.sprite = sp[0];
    }

    public void AddPrull()
    {
        stufinprullenbak++;
        AdS.Play();
    }
    private void FixedUpdate()
    {
        if (stufinprullenbak >  1)
        {
            sprenders.sprite = sp[1];
        }
        if(stufinprullenbak > 14)
        {
            sprenders.sprite = sp[2];
        }
        if(stufinprullenbak > 19)
        {
            sprenders.sprite = sp[3];
        }

        if(stufinprullenbak ==  0)
        {
            sprenders.sprite = sp[0];
        }
       
        if(stufinprullenbak < fullPrullebakint)
        {
            isvol = false;
        }
        
        
        if (stufinprullenbak >= fullPrullebakint)
        {
            Prullebakvol();
        }
        if (isvol == true)
        {
            //print("o ja ");
        }
        if(legen == true)
        {
            if (stufinprullenbak > 0)
            {
                time -= Time.deltaTime;
                if (time < 0)
                {
                    stufinprullenbak--;
                    Bigtrash.addtrash();
                    time = 0.3f;
                }
                if (stufinprullenbak == 20)
                {
                    sprenders.sprite = sp[2];
                }

                if (stufinprullenbak == 14)
                {
                    sprenders.sprite = sp[1];
                }
                if (stufinprullenbak == 1)
                {
                    sprenders.sprite = sp[0];
                }
            }
        }
        
       
    }
    public void turtel_no()
    {
        stufinprullenbak = 0;
        sprenders.sprite = sp[0];
    }
    
    public void Prullebakvol()  
    {
        isvol = true;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(Prullenbaknummer == 1)
        {
            if (collision.CompareTag("btc1"))
            {
                legen = true;
            }
        }
        if(Prullenbaknummer == 2)
        {
            if (collision.CompareTag("btc2"))
            {
                legen = true;
            }
        }
        if(Prullenbaknummer == 3)
        {
            if (collision.CompareTag("btc3"))
            {
                legen = true;
            }
        }
        if(Prullenbaknummer == 4)
        {
            if (collision.CompareTag("btc4"))
            {
                legen = true;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        legen = false;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(isvol == false)
        {
            if (other.CompareTag("trash"))
            {
                AddPrull();
                Destroy(other.gameObject);
            }

        }
        if (other.CompareTag("turtel"))
        {
            turtel_no();
            Destroy(other.gameObject);
        }
        
    }


}
