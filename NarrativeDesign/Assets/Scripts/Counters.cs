using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counters : MonoBehaviour
{
    private TextMeshProUGUI tomatoCounter;



   public void editTomatoCounter()
    {
        tomatoCounter.text = GetComponent<DetectiveTrigger>().wordCheck;
    }
    public void editCleanCounter()
    {

    }
    public void editCrayonCounter()
    {

    } 
    public void editLaughCounter()
    {

    }
    public void editBathroomEvidenceCounter()
    {

    } 

    public void editSpyEvidenceCounter()
    {

    }
    

}
