using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bathroomDetective : MonoBehaviour
{
    public string[] wordToComplete;
    public string[] letters;

    private int lettersInWord;
    private int lettersComplete;

    public Material[] chalkboard;

    private string[] lettersActivated;

    public MeshRenderer chalkboard1;
    private Material boardToAssign;

    void Start()
    {
        lettersInWord = wordToComplete.Length;
    }

    void Update()
    {
        //if string is = the amount of letters in word to complete then check the letters match



        if(lettersInWord == lettersComplete)
        {
            WordCheck();
        
        }
    }

    public void LetterComplete()
    {
        lettersComplete += 1;
    }

    public void WordCheck()
    {
        if (lettersActivated == wordToComplete)
        {
            boardToAssign = chalkboard[];
            chalkboard1.material = boardToAssign;
            ResetBlocks();
        }

    }
    private void ResetBlocks()
    {

    }
    
}
