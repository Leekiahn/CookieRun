using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedDownItem : MonoBehaviour,IItemEffect
{
    public float speedDown = -1.5f;

    public void ApplyEffect(IEffectTarget target)
    {
        //if (target is )//�� �̳� �÷��̾� 
        //{
        //    player.IncreeseSpeed(speedDown); //�ӽ÷� �÷��̾�
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
