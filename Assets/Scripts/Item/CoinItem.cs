using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinItem : Item, IItemEffect
{
    public float value = 10f;
    [SerializeField]
    private SpriteRenderer _renderer;

    public CoinItem(GroundObjectData data) : base(data)
    {

    }

    public void ApplyEffect(IEffectTarget target)
    {
        //if(target is Score score)
        //{
        //    score.AddScore(value);
        //}
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            var effectTarget = other.GetComponent<IEffectTarget>();
            if (effectTarget != null)
            {
                ApplyEffect(effectTarget);
                Destroy(gameObject);
            }
        }
    }


}
