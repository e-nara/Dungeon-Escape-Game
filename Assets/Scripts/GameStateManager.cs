using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    public GameObject coinPrefab;
    private Canvas myCanvas;

    //score management
    public int score;

    public int getScore()
    {
        return score;
    }

    public void SetScore(int s)
    {
        score = s;
    }

    public void adjustScore(int s)
    {
        score += s;
        //Debug.Log("Score is " + score); //no longer needed; handled by UI
    }

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Scene Loaded");
        myCanvas = GameObject.Find("Canvas").GetComponent<Canvas>();
        generateCoins(5);
        
        DontDestroyOnLoad(this.gameObject);
        //DontDestroyOnLoad(myCanvas.gameObject);

        if (FindObjectsOfType (this.GetType()).Length > 1){
            Destroy(this.gameObject);
        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void generateCoins(int numCoins)
    {
        //random coin placement
        GameObject tempCoin; 
        for (int i = 0; i < numCoins; i++)
        {
            tempCoin = Instantiate(coinPrefab, new Vector3(UnityEngine.Random.Range(-10,10), UnityEngine.Random.Range(-4,4), 0), Quaternion.identity);
        }
        //Debug.Log("Coins Generated");
    }
}
