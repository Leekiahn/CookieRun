using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpItem : Item, IItemEffect
{
    public float speedUp = 1.5f;
    [SerializeField]
    private SpriteRenderer _renderer;

    public SpeedUpItem(GroundObjectData data) : base(data)
    {

    }

    public void ApplyEffect(IEffectTarget target)
    {
        //if (target is )//�� �̳� �÷��̾� 
        //{
        //    player.IncreeseSpeed(speedUp); //�ӽ÷� �÷��̾�
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
