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

    private void OnTriggerEnter(Collider other)
    {
        IEffectTarget target = other.GetComponent<IEffectTarget>();
        if (target != null)
        {
            ApplyEffect(target);
            Destroy(gameObject); // ������ ����
        }
    }
}
