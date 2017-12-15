using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Scoreboard : MonoBehaviour {
    public static Scoreboard instance;

    public Text Score1;
    public Text Score2;

    int player1 = 0;
    int player2 = 0;


    // Use this for initialization
    void Start () {
        instance = this;
    }
	
	// Update is called once per frame
	void Update () {

    }

    public void GivePlayerTwoAPoint()
    {
        player2 += 1;
        Score2.text = player2.ToString();
    }

    public void GivePlayerOneAPoint()
    {
        player1 += 1;
        Score1.text = player1.ToString();
    }


}

