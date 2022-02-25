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
        health = 100;
        defense = 50;
        speed = 20;
        attack = 10;
        level = 0;
        curXp = 0;
        reqXp = 100;
            
    }

    public void Interation(int exp)
    {
        //An interation called by a button press
    }

    public void GainXP(int amount) //GainProgress
    {
        //increase our current xp
    }

    public void LevelUp() //CompleteLap
    {
        //increase our level
    }

    public void IncreaseStats()
    {
        //improve our stats
    }

}
