using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponDamageAmounts : MonoBehaviour
{
    public float swordDamage = 10f;
    public float maceDamage = 30f;
    public float arrowDamage = 100f;
    public float fireBallDamage = 20f;
    
    public float getSwordDamage()
    {
        return swordDamage;
    }
    public float getMaceDamage()
    {
        return maceDamage;
    }
    public float getArrowDamage()
    {
        return arrowDamage;
    }
    public float getFireBallDamage()
    {
        return fireBallDamage;
    }
}
