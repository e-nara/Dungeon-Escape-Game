using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehaviour : MonoBehaviour
{

    private AudioSource ding;
    private GameStateManager gsm;

    // Start is called before the first frame update
    void Start()
    {
        gsm = GameObject.Find("GameState").GetComponent<GameStateManager>();
        ding = GameObject.Find("SoundEffects").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(new Vector3(0,1,0));
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            gsm.adjustScore(10);
            ding.Play();
        }
    }
}
