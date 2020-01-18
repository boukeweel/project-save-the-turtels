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

    private bool GT0 = true;
    private bool GT1 = true;
    private bool GT2 = true;
    private bool GT3 = true;





    private void Start()
    {
        

        Finish_.SetActive(false);

        resetbutton.gameObject.SetActive(true);
        
        ressetimage.gameObject.SetActive(false);
        
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            GetHigestnummber();
            print(GT0);
            print(GT1);
            print(GT2);
            print(GT3);
        }
    }

    private void GetHigestnummber()
    {
        if(GT0 == true)
        {
            if(GT[0].afvalerin > GT[1].afvalerin)
            {
                GT1 = false;
            }
            else
            {
                GT0 = false;
            }
            if (GT[0].afvalerin > GT[2].afvalerin)
            {
                GT2 = false;
            }
            else
            {
                GT0 = false;
            }
            if (GT[0].afvalerin > GT[3].afvalerin)
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
            if (GT[1].afvalerin > GT[2].afvalerin)
            {
                GT2 = false;
            }
            else
            {
                GT1 = false;
            }
            if (GT[1].afvalerin > GT[3].afvalerin)
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
            if (GT[2].afvalerin > GT[3].afvalerin)
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
