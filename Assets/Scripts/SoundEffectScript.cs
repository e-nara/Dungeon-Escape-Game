using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectScript : MonoBehaviour
{
    //create reference for the Audio Source
    public AudioSource source; 
    public float effectsVolume;

    // Start is called before the first frame update
    void Start()
    {
        effectsVolume = PlayerPrefs.GetFloat("EffectsVolume");
        source = this.gameObject.GetComponent<AudioSource>();
        source.volume = effectsVolume; 
        //Debug.Log(effectsVolume);
        //Debug.Log(source.volume);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void effectsVolumeChanged(){
        effectsVolume = PlayerPrefs.GetFloat("EffectsVolume");
        source.volume = effectsVolume;
    }
}
