using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene2Script : MonoBehaviour
{

    GameObject blockade; //blockade reference

    //goal logic 
    public bool greenMatch;
    public bool blueMatch;
    public bool redMatch;
    public bool yellowMatch;

    // Start is called before the first frame update
    void Start()
    {
        blockade = GameObject.Find("blockade");

        greenMatch = false;
        blueMatch = false;
        redMatch = false;
        yellowMatch = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void checkGoalMatch(string tag)
    {
        if (tag == "green")
        {
            //Debug.Log("green match");
            greenMatch = true;
        }

        if (tag == "blue")
        {
            //Debug.Log("blue match");
            blueMatch = true;
        }

        if (tag == "red")
        {
            //Debug.Log("red match");
            redMatch = true;
        }

        if (tag == "yellow")
        {
            //Debug.Log("yellow match");
            yellowMatch = true;
        }

        if (redMatch == true && greenMatch == true && blueMatch == true && yellowMatch == true)
        {
            Destroy(blockade); 
        }
    }
}
