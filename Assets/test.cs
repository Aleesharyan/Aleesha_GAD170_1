using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{ //variables
    /*
     * multiline power
     */
    public int Fuel = 100;
    public int Laps;
    public float LapProgress;
    public float reqLapProgress = 200f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //check how much fuel we have
        //if we still have more than 0 fuel, lets go!
        if (Fuel > 0)
        {
            //we have fuel
            //increase our progress
            LapProgress += 5; //increase by 1
            Fuel--;
        }
        else
        {
            //we dont have fuel
            Debug.Log("We've run out of fuel!");
        }


        if (LapProgress >= reqLapProgress)
        {
            //if it is, inbcrease our lap count and reset our current progress
            Laps++; //increase laps by 1
            LapProgress = 0; //reset our lap progress
        }
        Debug.Log("current Fuel: " + Fuel);
        Debug.Log("Completed Laps: " + Laps);
    }
}

   


