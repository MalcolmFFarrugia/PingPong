using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller2 : MonoBehaviour
{
    public GameObject Player2;
    public float boundY = 5.5f;
    private Rigidbody2D rb2;


    // Use this for initialization
    void Start() {
        rb2 = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {

        float mousePos = (Input.mousePosition.y / Screen.height * 13f) - 6.5f;
        Vector3 Player2pos = new Vector3(12f, mousePos, this.transform.position.x);
        this.transform.position = Player2pos;

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
