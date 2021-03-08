using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResetButton : MonoBehaviour
{
    
    public GameObject ressetimage;
    public Button resetbutton;
    public GameObject Texten;
    public GameObject Finish_;

    public GrotenTrashcann[] GT;

    public Text winningtext;

    private bool GT0 = true;
    private bool GT1 = true;
    private bool GT2 = true;
    private bool GT3 = true;


    public float TimeofGame;


    private void Start()
    {
        

       
        Finish_.SetActive(false);

        resetbutton.gameObject.SetActive(true);
        
        ressetimage.gameObject.SetActive(false);
        
    }
    private void Update()
    {
        //begin de game timer
        TimeofGame -= Time.deltaTime;
        if(TimeofGame < 0)
        {
            TimeEnd();
        }
    }

    private void TimeEnd()
    {
        Time.timeScale = 0;
        GetHigestnummber();
        Finish_.SetActive(true);
        //wie heeft gewonen ander text
        if (GT0 == true)
        {
            winningtext.text = "De gene die meest heeft geholpen is Geel!";
        }
        if (GT1 == true)
        {
            winningtext.text = "De gene die meest heeft geholpen is Rood!";
        }
        if (GT2 == true)
        {
            winningtext.text = "De gene die meest heeft geholpen is Blauw!";
        }
        if(GT3 == true)
        {
            winningtext.text = "De gene die meest heeft gehoplen is Groen!";
        }
    }


    private void GetHigestnummber()
    {
        //checkin wie de hoogt antaal trash heeft versammelt
        if(GT0 == true)
        {
            if(GT[0].afvalErIn > GT[1].afvalErIn)
            {
                GT1 = false;
            }
            else
            {
                GT0 = false;
            }
            if (GT[0].afvalErIn > GT[2].afvalErIn)
            {
                GT2 = false;
            }
            else
            {
                GT0 = false;
            }
            if (GT[0].afvalErIn > GT[3].afvalErIn)
            {
                GT3 = false;
            }
            else
            {
                GT0 = false;
            }
        }
        if (GT1 == true)
        {
            if (GT[1].afvalErIn > GT[2].afvalErIn)
            {
                GT2 = false;
            }
            else
            {
                GT1 = false;
            }
            if (GT[1].afvalErIn > GT[3].afvalErIn)
            {
                GT3 = false;
            }
            else
            {
                GT1 = false;
            }

        }
        if(GT2 == true)
        {
            if (GT[2].afvalErIn > GT[3].afvalErIn)
            {
                GT3 = false;
            }
            else
            {
                GT2 = false;
            }
        }

    }

    public void Ressetbutton()
    {
        resetbutton.gameObject.SetActive(false);
        
        ressetimage.gameObject.SetActive(true);
    }

    public void ResetbuttonJa()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ResetbuttonNee()
    {
        resetbutton.gameObject.SetActive(true);
        ressetimage.gameObject.SetActive(false);
    }
    public void Finish()
    {
        Texten.SetActive(false);
        ressetimage.SetActive(false);
        ressetimage.gameObject.SetActive(false);
    }
}
