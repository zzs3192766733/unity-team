using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cs : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    private float jumpHight=10;

    private void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, jumpHight);
        }
    }
}
