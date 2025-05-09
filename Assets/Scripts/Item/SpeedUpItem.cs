using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpItem : MonoBehaviour, IItemEffect
{
    public float speedUp = 1.5f;

    public void ApplyEffect(IEffectTarget target)
    {
        //if (target is )//맵 이나 플레이어 
        //{
        //    player.IncreeseSpeed(speedUp); //임시로 플레이어
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
