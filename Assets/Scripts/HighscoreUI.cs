using System.Collections;
using System.Collections.Generic;
using TMPro;
using System;
using UnityEngine;

public class HighscoreUI : MonoBehaviour
{
    public TextMeshProUGUI myHighscore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        myHighscore.text = PlayerPrefs.GetInt("Highscore").ToString();
        //Debug.Log(PlayerPrefs.GetInt("Highscore"));
    }
}
