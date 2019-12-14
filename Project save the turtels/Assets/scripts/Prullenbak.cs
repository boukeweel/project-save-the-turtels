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


    public void AddPrull()
    {
        stufinprullenbak++;
    }
    private void Update()
    {
       
        vullen_text.text = "afval in prullenbak"+ Prullenbaknummer.ToString() + " " + stufinprullenbak.ToString();
        if(isvol == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                AddPrull();
            }
            if (stufinprullenbak == fullPrullebakint)
            {
                Prullebakvol();
            }
        }
        if(isvol == true)
        {
            print("o ja ");
        }
       
    }
    public void Prullebakvol()  
    {
        isvol = true;
    }
   

}
