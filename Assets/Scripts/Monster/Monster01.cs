using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster01 :MonsterBase
{
    private float directionChangeTime = 2;//改变方向的时间间隔
    private float totalTime;//加deltaTime的
    private bool flag;//移动方向的标志
    public override void Attack()
    {
        base.Attack();
    }
    /// <summary>
    /// 左右移动
    /// </summary>
    public override void Move()
    {
        totalTime += Time.deltaTime;
        if (flag)
            this.transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
        else
            this.transform.Translate(-moveSpeed * Time.deltaTime, 0, 0);
        if (totalTime >= directionChangeTime)
        {
            totalTime = 0;
            flag = !flag;
        }
    }
    public override void CheckDeath()
    {
        base.CheckDeath();
    }
}
