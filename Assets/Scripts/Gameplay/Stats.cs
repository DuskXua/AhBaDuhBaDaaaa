using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    //Creates Stat Values in inspector -- Maybe theres a way we can use other scrips to effect this one? EX: Speed potion & leveling up
    public int speed;
    public int strength;
    public int intelligence;
    public int accuracy;
    public int vitality;
    public float hp;
    public float ap;
    public float sp;


    public float hpMax;
    public float apMax;
    public float spMax;

    public float hpRegen;
    public float apRegen;
    public float spRegen;









    void Setup()
    {
        hpMax = 100;
        hp = hpMax;

        apMax = 2;
        ap = apMax;

        spMax = 200;
        sp = spMax;

        hpRegen = 5;
        apRegen = 1;
        spRegen = 5;
    }

    void Start()
    {
        Setup();


       

    }
    void Update()
    {
        //Regen
        hp += hpRegen * Time.deltaTime;
        if(hp >= hpMax)
        {
            hp = hpMax;
        }

        ap += apRegen * Time.deltaTime;
        if (ap >= apMax)
        {
            ap = apMax;
        }

        sp += spMax * Time.deltaTime;
        if (sp >= spMax)
        {
            sp = spMax;
        }
    }
}
