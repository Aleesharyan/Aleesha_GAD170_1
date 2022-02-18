using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacingScript : MonoBehaviour
{
    //variables

    int laps = 1;

    float curLapProgress = 0.0f;
    float reqLapProgress = 100.0f;

    float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GainProgress(speed);
        }
    }


    public void GainProgress(float progress)
    {
        curLapProgress += progress;
        Debug.Log("Gained" + progress + "progress");
        Debug.Log("Total current progress is now: " + curLapProgress);
        CheckProgress(curLapProgress);
    }

    public void CheckProgress(float progress)
    {
        if(progress >= reqLapProgress)
        {
            //complete a lap! (REPLACE BELOW LINES WITH LAPCOMPLETED FUNCTION)
            LapCompleted();
            Debug.Log("Reached the required amount of progress");
        }
    }

    public void LapCompleted()
    {
        //update laps
        laps++;
        //update curProgress
        curLapProgress = 0f;
        //update reqProgress
        reqLapProgress *= 1.15f;
        //update speed
        Debug.Log("Completed " + laps + "laps");
    }
    

    

    
}
