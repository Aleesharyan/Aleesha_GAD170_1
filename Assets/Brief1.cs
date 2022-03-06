using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brief1 : MonoBehaviour
{
    public int level; //laps

    public float curXp; //curLapProgress
    public float reqXp; //reqLapProgress

    //stats variables (to be tracked and modified upon level up)
    public float health;
    public float defense;
    public float speed;
    public float attack;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InitialStats()
    {
        //Initialize stats, level xp, reqxp etc.
        health = 100f;
        defense = 50f;
        speed = 20f;
        attack = 10f;
        level = 0;
        curXp = 0f;
        reqXp = 100f;
            
    }

    public void Interation(int exp)
    {
        //An interation called by a button press
        if (Input.GetKeyDown(KeyCode.Space))
        {
            speed++;
        }
    }

    public void GainXP(int amount) //GainProgress
    {
        //increase our current xp
        curXp += amount;
        Debug.Log("Gained" + amount + "XP");
        Debug.Log("Total current XP is now: " + curXp);
        CheckProgress(curXp);
    }

    public void CheckProgress(float amount)
    {
        if (amount >= reqXp)
        {
            LevelUp();
            Debug.Log("Player has leveled up");
        }
    }

    public void LevelUp() //CompleteLap
    {
        level++;
        curXp = 0f;
        reqXp *= 100;
    }

    public void IncreaseStats()
    {
        if (curXp >= reqXp)
        {
            health += 5f;
            defense += 5f;
            speed += 5f;
            attack += 5f;
        }
    }

}
