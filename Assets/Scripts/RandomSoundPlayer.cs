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
        //May need to work on this line. It was too dark for me to really tell what I am typing.
        soundtimer = soundtimer + Time.deltaTime;
	}
}
