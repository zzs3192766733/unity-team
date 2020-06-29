using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBase : MonoBehaviour
{
    protected BoxCollider2D co;
    protected void Start()
    {
        co = GetComponent<BoxCollider2D>();
    }
    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}
