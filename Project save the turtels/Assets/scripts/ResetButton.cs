using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetButton : MonoBehaviour
{
    public Button resetbuttonOne;
    public Button resetbuttonTwo;
    

    private void Start()
    {
        resetbuttonTwo.gameObject.SetActive(true);
    }

    public void ResetButtonOne()
    {
        resetbuttonTwo.gameObject.SetActive(true);
        resetbuttonOne.gameObject.SetActive(false);
    } 

}
