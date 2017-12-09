using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    Rigidbody2D rb;
    Vector2 vel;

    // Use this for initialization
    void Start() {
        //Ball chooses direction
        rb = GetComponent<Rigidbody2D>();

        transform.position = Vector2.zero;

        int xDirection = Random.Range(0, 2);
        int yDirection = Random.Range(0, 2);

        Vector3 launchDirection = new Vector3();
        //checking result of random for x
        if (xDirection == 0) {
            launchDirection.x = -7f;
        } else if (xDirection == 1) {
            launchDirection.x = 7f;
        }

        //checking result of random for y
        if (yDirection == 0)
        {
            launchDirection.y = -7f;
        }
        else if (yDirection == 1)
        {
            launchDirection.y = 7f;
        }
            //launching ball
            rb.velocity = launchDirection;

    }

    void Update() {
        if(transform.position.x < -13f)
        {
            ScoreBoard.instance.PlayerTwoGoal();
            Start();
        }

        if (transform.position.x > 13f)
        {
            ScoreBoard.instance.PlayerOneGoal();
            Start();
        }
    }
 }


