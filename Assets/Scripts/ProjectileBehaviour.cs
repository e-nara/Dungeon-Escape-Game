using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{

    public Rigidbody2D myRigid;

    // Start is called before the first frame update
    void Start()
    {
        myRigid = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        myRigid.AddForce(this.transform.right * 10);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject);
        //destroy the projectile if it hits anything
    }
}
