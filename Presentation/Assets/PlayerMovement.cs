using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public KeyCode left, right;
    public float buildUp;
    public float maxSpeed;

    public KeyCode jump;
    public float jumpforce;

    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Move left and right.
        if (Input.GetKey(left))
        {
            rb2d.AddForce(Vector2.left * buildUp);
        }
        {
            if (Input.GetKey(right))
            {
                rb2d.AddForce(Vector2.right * buildUp);
            }

            //Jump.
            if (Input.GetKeyDown(jump))
            {
                rb2d.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);
            }

            //Clamp the velocity.
            rb2d.velocity = new Vector2(Mathf.Clamp(rb2d.velocity.x, -maxSpeed, maxSpeed), rb2d.velocity.y);
        }
    }
}