using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedDownItem : MonoBehaviour,IItemEffect
{
    public float speedDown = -1.5f;

    public void ApplyEffect(IEffectTarget target)
    {
        //if (target is )//맵 이나 플레이어 
        //{
        //    player.IncreeseSpeed(speedDown); //임시로 플레이어
        //}
    }

    private void OnTriggerEnter(Collider other)
    {
        IEffectTarget target = other.GetComponent<IEffectTarget>();
        if (target != null)
        {
            ApplyEffect(target);
            Destroy(gameObject); // 아이템 제거
        }
    }
}
