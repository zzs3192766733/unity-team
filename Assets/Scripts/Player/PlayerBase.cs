using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBase : MonoBehaviour
{
    private float hitPoint;
    private float damage;
    private float energy;
    private int moveSpeed = 8;
    private int climbSpeed = 5;
    private int jumpForce = 10;
    protected bool isClimbing;
    protected Rigidbody2D rb;
    protected CapsuleCollider2D co;
    protected Animator animator;
    public LayerMask layerMask;

    public float HitPoint { get => hitPoint; set => hitPoint = value; }
    public float Damage { get => damage; set => damage = value; }
    public float Energy { get => energy; set => energy = value; }

    protected void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        co = GetComponent<CapsuleCollider2D>();
        animator = GetComponent<Animator>();
        layerMask = LayerMask.NameToLayer("Road");
    }
    protected void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(hor * moveSpeed, rb.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            animator.SetBool("Is jumpup",true);
        }
        if(isClimbing)
        {
            float ver = Input.GetAxis("Vertical");
            rb.velocity = new Vector2(rb.velocity.x, ver * climbSpeed);
        }
        //设置状态机里面的Speed
        animator.SetFloat("Speed", Mathf.Abs(hor));
        if (hor > 0)
        {
            this.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (hor < 0)
        {
            this.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        if (Mathf.Abs(rb.velocity.y) <= 0.01f && rb.velocity.y != 0 && !(rb.velocity.y>=0.00000000000000001f&&rb.velocity.y<=0.000001f))
        {
            animator.SetBool("Is jumpup", false);
            animator.SetBool("Is jumpdown", true);
        }
        if (co.IsTouchingLayers(layerMask))
        {
            Debug.Log("123");
            animator.SetBool("Is jumpdown", false);
        }

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
