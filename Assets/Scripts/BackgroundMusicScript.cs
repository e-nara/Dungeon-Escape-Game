using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusicScript : MonoBehaviour
{

    //create reference for the Audio Source
    public AudioSource source; 
    public float musicVolume;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);

        if (FindObjectsOfType (this.GetType()).Length > 1){
            Destroy(this.gameObject);
        } 
        //prevents the music from stopping and starting every new scene

        musicVolume = PlayerPrefs.GetFloat("MusicVolume");
        source = this.gameObject.GetComponent<AudioSource>();
        //Debug.Log(musicVolume);
        source.volume = musicVolume; //doing this does change the volume
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void musicVolumeChanged(){
        musicVolume = PlayerPrefs.GetFloat("MusicVolume");
        source.volume = musicVolume;
    }
}
