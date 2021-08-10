using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterBlocks : MonoBehaviour
{
    public char blockLetter;
    private Vector3 startingPosition;

    void Start()
    {
        startingPosition = this.transform.position;
    }

    public void ResetBlocks()
    {
        transform.position = startingPosition;
    }

}
