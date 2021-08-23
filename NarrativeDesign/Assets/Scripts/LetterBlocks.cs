using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterBlocks : MonoBehaviour
{
    public char blockLetter;
    private Vector3 startingPosition;
    public GameObject DT;

    public Material MaterialToAssign, original;
    public MeshRenderer block;


    void Start()
    {
        startingPosition = this.transform.position;
    }

    public void ResetBlocks()
    {
        transform.position = startingPosition;
    }

    void OnMouseDown()
    {
        DT.GetComponent<DetectiveTrigger>().AddToList(gameObject);

        ChangeBlockColour();
    }

    void ChangeBlockColour()
    {
        block.material = MaterialToAssign;
        StartCoroutine(ChangeOnClick());
    }

    public IEnumerator ChangeOnClick()
    {
        yield return new WaitForSeconds(1);
        block.material = original;
    }
}
