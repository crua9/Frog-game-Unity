using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour {

    public static int score;

    private Text scoreCounterText;

	// Use this for initialization
	void Start () {
        score = 0;
        scoreCounterText = GetComponent<Text>();
	}
	
	// Update is called once per frame
    /*
      This will update the score per frame. Since it's a small app, I don't think it matters that much to do this.
     */
	void Update () {
        scoreCounterText.text = "Score:" + score;
	}
}
