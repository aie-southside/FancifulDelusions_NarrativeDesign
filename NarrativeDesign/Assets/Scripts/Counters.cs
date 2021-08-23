using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counters : MonoBehaviour
{
   
    public TextMeshProUGUI bathroomEvidenceCounter; 
    public TextMeshProUGUI spyEvidenceCounter; 
    public TextMeshProUGUI kitchenEvidenceCounter;

    private int bathEvCount = 0;
    private int spyEvCount = 0;

    

    private void Update()
    {
  
    }


    public void editBathroomEvidenceCounter()
    {
        bathroomEvidenceCounter.text = bathEvCount + " /7 pieces of evidence";
    } 

    public void editSpyEvidenceCounter()
    {
        spyEvidenceCounter.text = spyEvCount + " /4 pieces of evidence";
    } 
    public void editKitchenEvidenceCounter()
    {
        kitchenEvidenceCounter.text = spyEvCount + " /4 pieces of evidence";
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
    public void AddEvidenceKitchen()
    {
        spyEvCount += 1;
        editKitchenEvidenceCounter();
    }
    
}
