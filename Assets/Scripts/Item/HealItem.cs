using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealItem : MonoBehaviour,IItemEffect
{
    public float value = 15f;

    public void ApplyEffect(IEffectTarget target)
    {
        //if (target is Player player )
        //{
        //    player.Heal(value);
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
