using System.Collections;
using System.Collections.Generic;
using TMPro;
using System;
using UnityEngine;

public class scoreUI : MonoBehaviour
{
    public TextMeshProUGUI myScoreUpdate;
    private GameStateManager gsm;

    // Start is called before the first frame update
    void Start()
    {
        gsm = GameObject.Find("GameState").GetComponent<GameStateManager>();
    }

    // Update is called once per frame
    void Update()
    {
        myScoreUpdate.text = gsm.score.ToString();
    }
}
