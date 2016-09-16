using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RandomSoundPlayer : MonoBehaviour {

    private AudioSource audiosource;
    [SerializeField]
    private List<AudioClip> soundClips = new List<AudioClip>();
    [SerializeField]
    private float soundTimerDelay = 3f;
    private float soundtimer;
    // Use this for initialization
    void Start () {
        audiosource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
       
        soundtimer = soundtimer + Time.deltaTime;

        if (soundtimer >= soundTimerDelay)
        {
            //reset timer
            soundtimer = 0f;
            //pick a random sound
            AudioClip randomSound = soundClips[Random.Range(0, soundClips.Count)];

            //play the sound
            audiosource.PlayOneShot(randomSound);
        }
	}
}
