using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectiveTrigger : MonoBehaviour
{
    public string wordToComplete;

    public List<char> ongoingList;
    public string wordCheck;


    public LetterBlocks[] letters;

    public Transform[] positions;
    



    void Start()
    {
        
    }

    

    void Update()
    {

        if(ongoingList.Count == wordToComplete.Length)
        {
            WordCheck();
        
        }
    }

    public void WordCheck()
    {
        
        
        foreach (char character in ongoingList)
        {
            wordCheck += character;
        }
        if (wordCheck == wordToComplete)
        {
            //edit gameworld textbox
            foreach (LetterBlocks blocks in letters)
            {
                blocks.ResetBlocks();
            }

        }
        else
        {
            RestartAttempt();
        }
        
   
    }


    private void RestartAttempt()
    {
        ongoingList.Clear();
        foreach (LetterBlocks blocks in letters)
        {
            blocks.ResetBlocks();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Block")
        {
            Debug.Log("triggered");
            //eventually make it so first block goes to first position in list etc.
            ongoingList.Add(other.GetComponent<LetterBlocks>().blockLetter);
            //set position of block
            
        }
    }
}
