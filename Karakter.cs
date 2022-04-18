using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Karakter : MonoBehaviour
{
    Rigidbody2D rigidbody;
    
    public float speed=8f;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        rigidbody.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rigidbody.velocity.y);
    }
}
