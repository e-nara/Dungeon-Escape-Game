using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalZone : MonoBehaviour
{
    Scene2Script goalLogic;

    // Start is called before the first frame update
    void Start()
    {
        goalLogic = GameObject.Find("Scene2Manager").GetComponent<Scene2Script>();
    }

    //goalzones check for collision
    //gamestate keeps track of state of matches (calls functions) tells which thing to set to true

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        string ballTag = collision.gameObject.tag;
        string goalTag = this.gameObject.tag;
        if (ballTag == goalTag)
        {
            goalLogic.checkGoalMatch(goalTag);          
        }
    }
}
