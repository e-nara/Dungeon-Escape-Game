using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene1Script : MonoBehaviour
{

    public GameObject spikePrefab;
    public float spikesLastFired;
    private GameStateManager gsm;

    // Start is called before the first frame update
    void Start()
    {
        //ensure score is 0 at the start of the game
        gsm = GameObject.Find("GameState").GetComponent<GameStateManager>();
        gsm.score = 0;
        spikesLastFired = 0;
        generateBottomSpikes();
        generateTopSpikes();
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > spikesLastFired + 2.5f) //spikes generate intermittently
        {
            generateBottomSpikes();
            generateTopSpikes();
            spikesLastFired = Time.time;
        }
    }

    public void generateBottomSpikes() //saves repeating code
    {
        //Spawn in a grid 
        GameObject tempSpike;
        for (int i = 0; i < 4; i++)
        {
            tempSpike = Instantiate(spikePrefab, new Vector3(5+(i-2)*3, -3.485f, 0), Quaternion.identity);
            randomSpikeSpeed(tempSpike);
        }
    }

    public void generateTopSpikes()
    {
        GameObject tempSpike;
        for (int i = 0; i < 4; i++)
        {
            tempSpike = Instantiate(spikePrefab, new Vector3(3.5f+(i-2)*3, 3, 0), Quaternion.identity);
            tempSpike.transform.Rotate(new Vector3(0,0,180));
            randomSpikeSpeed(tempSpike);
        }
    }

    public void randomSpikeSpeed(GameObject tempSpike)
    {
        SpikeBehaviour sb;
        sb = tempSpike.GetComponent<SpikeBehaviour>();
        sb.force = Random.Range(0.1f,1f);
    }
}
