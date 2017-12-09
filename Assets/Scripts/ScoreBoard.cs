using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreBoard : MonoBehaviour {

    public static ScoreBoard instance;

    public Text Score1;
    public Text Score2;

    public int player1;
    public int player2;

	// Use this for initialization
	void Start () {
        instance = this;

        player1 = player2 = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlayerOneGoal() {
        player1 += 1;
        Score1.text = player1.ToString();
    }

    public void PlayerTwoGoal() {
        player2 += 1;
        Score2.text = player2.ToString();
    }

}
