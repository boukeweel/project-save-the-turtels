using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Prullenbak : MonoBehaviour
{
    public int stufinprullenbak;
    public int fullPrullebakint;

    public int Prullenbaknummer;

    public Text vullen_text;

    bool isvol = false;

    public bool legen = false;

    public float time = 0.5f;


    public void AddPrull()
    {
        stufinprullenbak++;
    }
    private void FixedUpdate()
    {
        if (stufinprullenbak >= fullPrullebakint)
        {
            Prullebakvol();
        }
        if(stufinprullenbak < fullPrullebakint)
        {
            isvol = false;
        }
        
        vullen_text.text = "afval in prullenbak"+ Prullenbaknummer.ToString() + " " + stufinprullenbak.ToString();
        
        if(isvol == true)
        {
            print("o ja ");
        }
        if(legen == true)
        {


            
            
            if (stufinprullenbak > 0)
            {
                time -= Time.deltaTime;
                if (time < 0)
                {
                    stufinprullenbak--;
                    
                    time = 0.5f;
                }
            }
        }
        
       
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
        
    }


}
