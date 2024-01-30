using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSpeed;
    public Rigidbody2D rigidBody;
    public float startingPostitionX;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(startingPostitionX, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            rigidBody.velocity = Vector2.down * movementSpeed;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            rigidBody.velocity = Vector2.up * movementSpeed;
        }
        else
        {
            rigidBody.velocity = Vector2.zero;
        }

    }
}
