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
    protected Animator animator;
    protected void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        co = GetComponent<CircleCollider2D>();
        animator = GetComponent<Animator>();
    }
    protected void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(hor * moveSpeed, rb.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            animator.SetBool("",false);
        }
        if(isClimbing)
        {
            float ver = Input.GetAxis("Vertical");
            rb.velocity = new Vector2(rb.velocity.x, ver * climbSpeed);
        }
        //设置状态机里面的Speed
        animator.SetFloat("Speed", Mathf.Abs(hor));
        PlayerRotation(hor);
    }
    protected void SwitchAnimator(float hor)
    {
    }
    protected void PlayerRotation(float hor)
    {
        if (hor > 0)
        {
            this.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (hor < 0)
        {
            this.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }
}
