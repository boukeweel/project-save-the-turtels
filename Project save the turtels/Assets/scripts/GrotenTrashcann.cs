using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrotenTrashcann : MonoBehaviour
{
    public int afvalerin;
    public Text DeText;
    
    private void Update()
    {
        DeText.text = "afval in de grote prullenbak " + afvalerin.ToString();
    }
    public void addtrash()
    {
        afvalerin++;
    }
}
