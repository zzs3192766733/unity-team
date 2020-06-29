using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterBase : MonoBehaviour
{
    public float hitPoint;
    public float damage;
    public int moveSpeed;
    protected CapsuleCollider2D co;
    protected void Awake()
    {
        co = GetComponent<CapsuleCollider2D>();
    }
    protected void Update()
    {
        Move();
        CheckDeath();
    }
    /// <summary>
    /// 怪物攻击
    /// </summary>
    public virtual void Attack()
    {

    }
    /// <summary>
    /// 怪物移动
    /// </summary>
    public virtual void Move()
    {
        
    }
    /// <summary>
    /// 检测怪物死亡
    /// </summary>
    public virtual void CheckDeath()
    {
        if (hitPoint <= 0) Destroy(gameObject);
    }
}
