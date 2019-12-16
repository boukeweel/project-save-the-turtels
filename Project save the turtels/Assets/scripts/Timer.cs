//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.SceneManagement;

//public class Timer : MonoBehaviour
//{
//    private float timer;
//    private bool canCount = true;
//    private bool doOnce = false;

//    void Start()
//    {
//        timer = mainTimer;
//    }

//    void Update()
//    {
//        if (timer >= 0.0f && canCount)
//        {
//            timer -= Time.deltaTime;
//            uiText.text = timer.ToString("F");
//        } 
//    }

//}