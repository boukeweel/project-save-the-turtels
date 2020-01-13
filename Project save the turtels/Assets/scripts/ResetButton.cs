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
    //public GameObject Finish_;

    private void Start()
    {
        //Finish_.SetActive(false);
        
        resetbutton.gameObject.SetActive(true);
        
        ressetimage.gameObject.SetActive(false);
        
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
