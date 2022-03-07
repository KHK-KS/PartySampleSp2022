using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    //hitbox object, also add checks for crazy meter and attack rate
    [Header("MetaData")]
    public float attack;
    public float fireRate;
    public float pierce; //possible idea, reduction to armor
    public string weaponName;
    private double nextFire = 0.0f;
    [Header("HitBoxes")]
    public HitBox LMBBox;
    public HitBox LMBChargeBox;
    public HitBox RMBBox;
    public HitBox RMBChargeBox;

    public void Attack(string fireType)
    {
        if (CheckConstraints())
        {
            switch (fireType)
            {
                case "Fire1":
                    LMBAttack();
                    break;
                case "Fire2":
                    LMBChargedAttack();
                    break;
                case "Fire3":
                    RMBAttack();
                    break;
                case "Fire4":
                    RMBChargedAttack();
                    break;
            }
        }
    }
    
    private bool CheckConstraints()
    {
        if (Time.timeAsDouble > nextFire) //Add Crazy Constraint
        {
            nextFire = Time.timeAsDouble + fireRate;
            return true;
        }
        return false;
    }

    public void LMBAttack()
    {
        //use LMBBox
    }

    public void LMBChargedAttack()
    {
        //use LMBChargeBox
    }

    public void RMBAttack()
    {
        //use RMBBox
    }

    public void RMBChargedAttack()
    {
        //use RMBChargeBox
    }
}