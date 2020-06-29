using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest :ItemBase
{
    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("你捡到了宝箱");
        Destroy(gameObject);
    }
}