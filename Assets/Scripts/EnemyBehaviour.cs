using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    GameObject blockade;
    ParticleSystem hitParticles;
    public int enemyHealth;
    public int maxEnemyHealth;
    public Vector3 originalEnemySize;

    //speed of movement
    public float speed = 2;

    // Start is called before the first frame update
    void Start()
    {
        hitParticles = GameObject.Find("Particle System").GetComponent<ParticleSystem>();
        blockade = GameObject.Find("blockade");
        maxEnemyHealth = 20;
        originalEnemySize = this.transform.localScale;
        enemyHealth = maxEnemyHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyHealth <= maxEnemyHealth && enemyHealth > maxEnemyHealth*0.75f){
            //do nothing
        }
        else if (enemyHealth <= maxEnemyHealth*0.75f && enemyHealth > maxEnemyHealth*0.5f)
        {
            this.transform.localScale = originalEnemySize*0.75f;
        }
        else if (enemyHealth <= maxEnemyHealth*0.5f && enemyHealth > 0)
        {
            this.transform.localScale = originalEnemySize*0.5f;
        }
        else
        {
            Destroy(this.gameObject);
            Destroy(blockade);
        }
    }

    public void moveToNextWaypoint()
    {
        //get next waypoint
        //move the enemy to goal point
        //check the distance between the enemy and goal point to trigger next point
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "projectile")
        {
            enemyHealth--;
            //Debug.Log(enemyHealth);
            Destroy(collision.gameObject);
            hitParticles.Play();
        }
    }
}
