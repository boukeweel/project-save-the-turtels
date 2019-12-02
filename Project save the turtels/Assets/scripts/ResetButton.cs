using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResetButton : MonoBehaviour
{
    
    public GameObject ressetimage;
    public Button resetbutton;

    private void Start()
    {
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
}
