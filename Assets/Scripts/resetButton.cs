using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetButton : MonoBehaviour
{


    public Vector3 circle1Start;
    public Vector3 circle2Start;
    public Vector3 circle3Start;
    public Vector3 circle4Start;
    private Scene2Script sc2c;
    public BallBehaviour bb;

    // Start is called before the first frame update
    void Start()
    {
        bb = GameObject.Find("circle1").GetComponent<BallBehaviour>();
        sc2c = GameObject.Find("Scene2Manager").GetComponent<Scene2Script>();
        circle1Start = GameObject.Find("circle1").transform.position;
        circle2Start = GameObject.Find("circle2").transform.position;
        circle3Start = GameObject.Find("circle3").transform.position;
        circle4Start = GameObject.Find("circle4").transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //resets stuff
        //look into that thing we learned about game state and reloads
        GameObject.Find("circle1").transform.position = circle1Start;
        GameObject.Find("circle2").transform.position = circle2Start;
        GameObject.Find("circle3").transform.position = circle3Start;
        GameObject.Find("circle4").transform.position = circle4Start;

        GameObject.Find("circle1").GetComponent<BallBehaviour>().myRigid.velocity = new Vector3(0, 0, 0);
        GameObject.Find("circle2").GetComponent<BallBehaviour>().myRigid.velocity = new Vector3(0, 0, 0);
        GameObject.Find("circle3").GetComponent<BallBehaviour>().myRigid.velocity = new Vector3(0, 0, 0);
        GameObject.Find("circle4").GetComponent<BallBehaviour>().myRigid.velocity = new Vector3(0, 0, 0);
        
        sc2c.greenMatch = false;
        sc2c.blueMatch = false;
        sc2c.redMatch = false;
        sc2c.yellowMatch = false;
    }
}
