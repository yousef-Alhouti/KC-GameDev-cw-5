using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    Rigidbody2D RB;
    float playerinput;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

  
    private void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        playerinput = Input.GetAxis("Horizontal");
        RB.velocity = new Vector2(playerinput * speed, 1);
    }

}
