using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class OptionsMenu : MonoBehaviour
{
    public Slider musicVolumeSlider;
    public Slider effectsVolumeSlider;
    private BackgroundMusicScript bgm;
    private SoundEffectScript sfx;

    // Start is called before the first frame update
    void Start()
    {
        bgm = GameObject.Find("BackgroundMusic").GetComponent<BackgroundMusicScript>();
        sfx = GameObject.Find("SoundEffects").GetComponent<SoundEffectScript>();
        musicVolumeSlider.value = PlayerPrefs.GetFloat("MusicVolume", 0.75f);
        effectsVolumeSlider.value = PlayerPrefs.GetFloat("EffectsVolume", 0.75f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateMusicVolume(){
        PlayerPrefs.SetFloat("MusicVolume", musicVolumeSlider.value);
        bgm.musicVolumeChanged();
    }

    public void updateEffectsVolume(){
        PlayerPrefs.SetFloat("EffectsVolume", effectsVolumeSlider.value);
        sfx.effectsVolumeChanged();
        sfx.source.Play(); //for the user to guage the sound to their preference
        //Debug.Log("ding");
        //Debug.Log(sfx.source.volume);
    }
}
