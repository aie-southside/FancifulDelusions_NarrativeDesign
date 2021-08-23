using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counters : MonoBehaviour
{
    //public TextMeshProUGUI tomatoCounter; 
    //public TextMeshProUGUI cleanCounter; 
    //public TextMeshProUGUI crayonCounter;
    //public TextMeshProUGUI laughCounter;
    public TextMeshProUGUI bathroomEvidenceCounter; 
    public TextMeshProUGUI spyEvidenceCounter;

    private int bathEvCount = 0;
    private int spyEvCount = 0;

    

    private void Update()
    {
        //editTomatoCounter();
        //editCleanCounter();
        //editCrayonCounter();
        //editLaughCounter();
        
    }

    //public void editTomatoCounter()
    //{
    //    string wC = GetComponent<DetectiveTrigger>().wordCheck;
    //    tomatoCounter.text = wC;
    //}
    //public void editCleanCounter()
    //{
    //    cleanCounter.text = GetComponent<DetectiveTrigger>().wordCheck;
    //}
    //public void editCrayonCounter()
    //{
    //    crayonCounter.text = GetComponent<DetectiveTrigger>().wordCheck;
    //} 
    //public void editLaughCounter()
    //{
    //    laughCounter.text = GetComponent<DetectiveTrigger>().wordCheck;
    //}
    public void editBathroomEvidenceCounter()
    {
        bathroomEvidenceCounter.text = bathEvCount + " /7 pieces of evidence";
    } 

    public void editSpyEvidenceCounter()
    {
        spyEvidenceCounter.text = spyEvCount + " /4 pieces of evidence";
    }
    
    public void AddEvidenceBath()
    {
        bathEvCount += 1;
        editBathroomEvidenceCounter();
    }
    public void AddEvidenceSpy()
    {
        spyEvCount += 1;
        editSpyEvidenceCounter();
    }
    
}
