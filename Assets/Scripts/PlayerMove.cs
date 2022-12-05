using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public string left;
    public string right;
    public string up;
    public string down;

    public Rigidbody2D myRigid;

    private Vector3 spawnPoint; 

    public GameObject projectilePrefab;

    public float lastFired;

    private GameStateManager gsm;

    // Start is called before the first frame update
    void Start()
    {
        myRigid = this.GetComponent<Rigidbody2D>();
        spawnPoint = new Vector3(-7,0,0);
        gsm = GameObject.Find("GameState").GetComponent<GameStateManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(up) || Input.GetKey(down) || Input.GetKey(right) || Input.GetKey(left))
        {
            //any player movement cancels forces acting upon it
            myRigid.velocity = new Vector2 (0f,0f);
        }

        if (Input.GetKey(up))
        {
            this.transform.Translate(new Vector3(0,0.01f,0));
        }

        if (Input.GetKey(down))
        {
            this.transform.Translate(new Vector3(0,-0.01f,0));
        }

        if (Input.GetKey(right))
        {
            this.transform.Translate(new Vector3(0.01f,0,0));
            this.GetComponent<SpriteRenderer>().flipX = false;
        }

        if (Input.GetKey(left))
        {
            this.transform.Translate(new Vector3(-0.01f,0,0));
            this.GetComponent<SpriteRenderer>().flipX = true;
        }

        if(Input.GetKey(KeyCode.Space))
        {
            GameObject tempProjectile;
            if(Time.time > lastFired + 0.2f)
            {
                tempProjectile = Instantiate(projectilePrefab, this.transform.position + (this.transform.right*1), this.transform.rotation);
                lastFired = Time.time;
                //controls the distance from the bullets to your spaceship. 10 is farther, 1 is closer
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "spike")
        {
            this.transform.position = spawnPoint; 
            //teleport back to spawn point if hit
            myRigid.velocity = new Vector2 (0f,0f);
            //reset velocity too, otherwise player has this weird ghostly floating after teleporting
        }
    }
}


