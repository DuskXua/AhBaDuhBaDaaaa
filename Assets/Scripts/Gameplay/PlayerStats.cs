using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    private PlayerUI ui;

    //Creates Stat Values in inspector -- Maybe theres a way we can use other scrips to effect this one? EX: Speed potion & leveling up
    //Base Stats
    public int Speed;
    public int Strength;
    public int Intelligence;
    public int Accuracy;
    public int Vitality;

    //Resources
    [SerializeField]
    private float hp;
    [SerializeField]
    private float ap;
    [SerializeField]
    private float sp;

    //Resource Maxes
    private float hpMax;
    private float apMax;
    private float spMax;

    //Resource Regen
    private float hpRegen;
    private float apRegen;
    private float spRegen;

    //Regen Cap in Percentage
    private float hpRegenCap;
    private float apRegenCap;
    private float spRegenCap;


    void InitializeStats()
    {
        Speed           = 10;
        Strength        = 10;
        Intelligence    = 10;
        Accuracy        = 10;
        Vitality        = 10;
    }

    void UpdateResources()
    {
        //set resources based off stats
        hpMax = 500;
        apMax = 2;
        spMax = 200;

        hpRegen = 5;
        apRegen = 1;
        spRegen = 5;

        hpRegenCap = .5f;
        apRegenCap = .1f;
        spRegenCap = 1f;
    }

    void InitializeResources()
    {
        UpdateResources();
        //Initialize Resources to max
        hp = hpMax;
        ap = apMax;
        sp = spMax;
    }

    void Start()
    {
        ui = GetComponent<PlayerUI>();
        InitializeStats();
        InitializeResources();
        UpdateUI();
    }

    void UpdateUI()
    {
        ui.UpdateResource(hp, hpMax, PlayerUI.ResourceType.Health);
        ui.UpdateResource(ap, apMax, PlayerUI.ResourceType.AbilityPoints);
        ui.UpdateResource(sp, spMax, PlayerUI.ResourceType.Stamina);
    }

    void Update()
    {
        DoResourceRegeneration(Time.deltaTime);
    }

    void DoResourceRegeneration(float time)
    {
        //Health
        if (hp / hpMax < hpRegenCap)
        {
            hp += hpRegen * time;
            if (hp >= hpMax)
                hp = hpMax;

            ui.UpdateResource(hp, PlayerUI.ResourceType.Health);
        }
        //Ability Points
        if (ap / apMax < apRegenCap)
        {
            ap += apRegen * time;
            if (ap >= apMax)
                ap = apMax;

            ui.UpdateResource(ap, PlayerUI.ResourceType.AbilityPoints);
        }
        //Stamina
        if (sp / spMax < spRegenCap)
        {
            sp += spRegen * time;
            if (sp >= spMax)
                sp = spMax;

            ui.UpdateResource(sp, PlayerUI.ResourceType.Stamina);
        }
    }

    public void Attack(GameObject target)
    {
        //checking if the target is a mob
        //could also check for boxes and stuff with durability
        if(target.TryGetComponent<MobStats>(out MobStats mob))
        {
            //Deal Damage to target
            mob.TakeDamage(1f);
        }


        //Regen AP based on the hit
    }

    public void TakeDamage(float amount)
    {
        //take Damage based on amount
        //Regen AP based on amount
    }

    public void RestoreHP(float amount)
    {
        //restore Hp
    }
    public void RestoreAP(float amount)
    {
        //Restore AP
    }
    public void RestoreSP(float amount)
    {
        //Restore SP
    }
}
