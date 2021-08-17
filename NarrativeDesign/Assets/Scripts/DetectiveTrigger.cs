using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DetectiveTrigger : MonoBehaviour
{
    public string wordToComplete;

    public List<char> ongoingList;
    public string wordCheck;


    public LetterBlocks[] letters;

    public Transform[] positions;

    public UnityEvent OnCorrect;


    void Start()
    {
        //Cursor.lockState = CursorLockMode.None;
        //Cursor.visible = true;

    }



    void Update()
    {

        if (ongoingList.Count == wordToComplete.Length)
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
           
            //foreach (LetterBlocks blocks in letters)
            //{
            //    blocks.ResetBlocks();
            //}

            OnCorrect.Invoke();

        }
        if (wordCheck != wordToComplete)
        {
            Debug.Log("INCORRECT");
            RestartAttempt();
        }
        
   
    }


    private void RestartAttempt()
    {
        ongoingList.Clear();
        wordCheck = string.Empty;
        //foreach (LetterBlocks blocks in letters)
        //{
        //    blocks.ResetBlocks();
        //}
    }
    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.tag == "Block")
    //    {
    //        Debug.Log("triggered");
    //        
    //        ongoingList.Add(other.GetComponent<LetterBlocks>().blockLetter);
      
    //    }
    //}
    public void AddToList(GameObject block)
    {
        ongoingList.Add(block.GetComponent<LetterBlocks>().blockLetter);
    }
   
}
