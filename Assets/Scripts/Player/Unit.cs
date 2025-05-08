using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    //최대 체력
    private const float fullHP = 100f;
    
    //HP
    [SerializeField] private float hp;
    protected float Hp
    {
        get { return hp; }
        set
        {
            hp = Mathf.Clamp(value, 0, fullHP);
        }
    }
    
    //스피드
    [SerializeField] private float speed;
    protected float Speed
    {
        get { return speed; }
        set
        {
            speed = Mathf.Max(0, value);
        }
    }

    protected virtual void Move(Vector3 dir)
    {
        transform.position += dir * speed * Time.deltaTime;
    }
}
