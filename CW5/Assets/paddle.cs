using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{
   public Rigidbody2D RB;

    float playerInput;

    public int speed;

    // Start is called before the first frame update
    void Start()
    {

        RB = GetComponent<Rigidbody2D>();
        
    }


    void FixedUpdate()
    {

        playerInput = Input.GetAxis("Horizontal");
        RB.velocity = new Vector2(playerInput * speed, 0);


    }
}