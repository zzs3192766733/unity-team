using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBase : MonoBehaviour
{
    public float hitPoint;
    public float damage;
    public float energy;
    public int moveSpeed = 8;
    public int climbSpeed = 5;
    public int jumpForce = 10;
    protected bool isClimbing;
    protected Rigidbody2D rb;
    protected CircleCollider2D co;
    protected void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        co = GetComponent<CircleCollider2D>();
    }
    protected void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(hor * moveSpeed, rb.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space))
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        if(isClimbing)
        {
            float ver = Input.GetAxis("Vertical");
            rb.velocity = new Vector2(rb.velocity.x, ver * climbSpeed);
        }
    }
}
