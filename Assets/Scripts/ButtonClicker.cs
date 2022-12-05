using System.Collections;
using System.Collections.Generic;
using TMPro;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClicker : MonoBehaviour
{
    public string whereToGo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            
    }

    public void changeScene()
    {
        SceneManager.LoadScene(whereToGo);
    }
}

