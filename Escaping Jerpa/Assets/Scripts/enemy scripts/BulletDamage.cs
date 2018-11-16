using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    [SerializeField]
    private int damage;

    public int Damage
    {
        get { return damage; }
        set
        {
            damage = value;
        }
    }

}
