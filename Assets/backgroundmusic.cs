﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backgroundmusic : MonoBehaviour
{
         void Awake ()
     {
         GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
         if (objs.Length > 1)
             Destroy(this.gameObject);
 
         DontDestroyOnLoad(this.gameObject);
 
     }

    // Update is called once per frame
    void Update()
    {
         if (SceneManager.GetActiveScene().name == "Sky" || SceneManager.GetActiveScene().name == "Lava")
         {
             Destroy(this.gameObject);
         }
        
    }
}
