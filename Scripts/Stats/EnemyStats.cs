using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : CharacterStats
{
    public override void Die ()
    {
        base.Die();

        //Add regdoll effect / deat animation 
        Destroy(gameObject);
    }
}
