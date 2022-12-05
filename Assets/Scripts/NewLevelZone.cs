using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewLevelZone : MonoBehaviour
{
    public string whereToGo;

    private GameStateManager gsm;

    // Start is called before the first frame update
    void Start()
    {
        gsm = GameObject.Find("GameState").GetComponent<GameStateManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(whereToGo);

            if (whereToGo == "WinScene")
            {
                if (PlayerPrefs.GetInt("Highscore") < gsm.score) //save highscore only if gsm.score is greater than the current highscore.
                {
                    PlayerPrefs.SetInt("Highscore", gsm.score);
                }
                //Debug.Log("Saving Playerprefs");
            }
        }
    }
}
