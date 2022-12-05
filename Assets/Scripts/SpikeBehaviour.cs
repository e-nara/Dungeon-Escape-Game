using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeBehaviour : MonoBehaviour
{
    public float force; //controlled by scene1manager
    public Rigidbody2D myRigid;
    
    // Start is called before the first frame update
    void Start()
    {
        myRigid = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.Translate(new Vector3(0,translation,0));
        myRigid.AddForce(this.transform.up * force);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "boundary")
        {
            Destroy(this.gameObject);
        }
    }
}
