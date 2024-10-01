using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementAnim : MonoBehaviour
{
    public float speed;

    private Animator _anim;
    private Rigidbody2D _rb2d;

    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();
        _rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _rb2d.AddForce(Vector2.left * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            _rb2d.AddForce(Vector2.right * Time.deltaTime * speed);
        }

        _anim.SetFloat("XSpeedAbs", Mathf.Abs(_rb2d.velocity.x));
    }
}
