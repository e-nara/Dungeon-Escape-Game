using System.Collections;
using System.Collections.Generic;
using TMPro;
using System;
using UnityEngine;

public class EnemyHealthUI : MonoBehaviour
{

    public TextMeshProUGUI myEnemyHealthUpdate;
    private EnemyBehaviour eb;

    // Start is called before the first frame update
    void Start()
    {
        eb = GameObject.Find("enemy").GetComponent<EnemyBehaviour>();
    }

    // Update is called once per frame
    void Update()
    {
        myEnemyHealthUpdate.text = eb.enemyHealth.ToString();
    }
}
