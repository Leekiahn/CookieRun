using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Unit
{
    void Start()
    {
        Hp = 100f;
        Speed = 3f;
    }

    
    void Update()
    {

    }

    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(horizontal, vertical).normalized;
        
        Move(dir);
    }

    protected override void Move(Vector3 dir)
    {
        base.Move(dir);
    }
}
