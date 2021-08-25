using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gameManager : MonoBehaviour
{
    public GameObject prevTile;
    public GameObject currentTile;
    public GameObject tilePrefab;
    public int score;
    public TextMeshProUGUI scoreText;
    public GameObject failScreen;
    public GameObject winScreen;
    public int requiredScore;

    public float speed = 0.01f;


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            PlayerClick();
        }
        if (currentTile != null)
        {
            currentTile.transform.localScale += new Vector3(1, 0, 1) * speed;
        }
        if(score == requiredScore)
        {
            winScreen.SetActive(true);
        }
        
    }

    public void PlayerClick()
    {
        if (currentTile == null)//first round or not
        {
            currentTile = Instantiate(tilePrefab, prevTile.transform.position + Vector3.up, prevTile.transform.rotation); //place tile 1 meter above last tile
        }
        else
        {
            if (prevTile.transform.localScale.x > currentTile.transform.localScale.x)//scale prev tile bigger than scale of current tile
            {
                prevTile = currentTile;
                currentTile = Instantiate(tilePrefab, prevTile.transform.position + Vector3.up, prevTile.transform.rotation);
                Camera.main.transform.position += Vector3.up;
                score++;
                scoreText.text = score.ToString()+"/25";
            }
            else
            {
                failScreen.SetActive(true);
            }
        }
       
    }
    
}