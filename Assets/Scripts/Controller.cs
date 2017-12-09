using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
    public GameObject Player1;
    public float boundY = 3.35f;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            Player1.GetComponent<Rigidbody2D>().velocity = new Vector3(0f, 5f, 0f);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            Player1.GetComponent<Rigidbody2D>().velocity = new Vector3(0f, -5f, 0f);
        }
        else if (!Input.anyKey)
        {
            Player1.GetComponent<Rigidbody2D>().velocity = new Vector3(0f, 0f, 0f);
        }

        var position = transform.position;
        if (position.y > boundY)
        {
            position.y = boundY;
        }
        else if (position.y < -boundY)
        {
            position.y = -boundY;
        }
        transform.position = position;

    }
}
