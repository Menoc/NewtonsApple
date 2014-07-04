using UnityEngine;
using System.Collections;

public class mainscript : MonoBehaviour {
	public int score=0;
	public int lives=3;
	public int highscore;
	public int target;

	public GUIText scoreText;
	public GUIText livesText;
	public GUIText targetText;

	// Use this for initialization
	void Start () {
//	target = Random.Range (1, 16);
		target = 11;
		scoreText.text = "Score: " + score;
		livesText.text = "Lives: " + lives;
		targetText.text = "Target Value: " + target;

	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
