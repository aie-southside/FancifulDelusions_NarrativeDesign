using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class getadopted : MonoBehaviour
{
   
    public GameObject player;
    public GameObject parent;
    public int currentHealthPlayer, maxPlayerHealth = 20;
    public int currentHealthParent, maxParentHealth = 20;

    public int playerDamage;
    public int parentDamage;


    public GameObject winScreen;
    public GameObject loseScreen;

    private bool phaseOne, phaseTwo;
    public GameObject[] playerMoves;

    private int selectedMove;
    private int selectedParentMove;

    public TextMeshProUGUI dialogue;


    void Start()
    {
        maxParentHealth = currentHealthParent;
        maxPlayerHealth = currentHealthPlayer;
    }

  
    void Update()
    {
        PlayerHealthCheck();
        ParentHealthCheck();
        
        if (phaseOne == true /*&& phaseTwo == false*/)
        {
            PhaseOne();
        }
        //if (phaseTwo == true && phaseOne == false)
        //{
        //    PhaseTwo();
        //}

    }

    public void ParentHealthCheck()
    {
        if(currentHealthParent >= 0)
        {
            winScreen.SetActive(true);
        }
    }
    public void PlayerHealthCheck()
    {
        if(currentHealthPlayer >= 0)
        {
            loseScreen.SetActive(true);
        }
    }

    public void ParentTakeDamage()
    {
        currentHealthParent -= playerDamage;
    }

    public void PlayerTakeDamage()
    {
        currentHealthPlayer -= parentDamage;
        //need to incorperate health bars still
    }
    public void PlayerHeal()
    {
        currentHealthPlayer += 1;
        //health bar
    }

    public void PhaseOne()
    {
        foreach(GameObject move in playerMoves)
        {
            move.SetActive(false);
        }
        selectedMove = Random.Range(0, playerMoves.Length);
        playerMoves[selectedMove].SetActive(true);

    }

    public void PhaseTwo()
    {
        SelectParentMove();
        
    }

    public void SelectParentMove()
    {
        selectedParentMove = Random.Range(1, 5);

        if(selectedParentMove == 1)
        {
            Insult();
        }
        if(selectedParentMove == 2)
        {
            Compliment();
        }
        if(selectedParentMove == 3)
        {
            Shame();
        }
        if(selectedParentMove == 4)
        {
            Rejection();
        }

    }


    public void Cry()
    {
        dialogue.text = "Charlie uses cry";
        playerDamage = Random.Range(0, 5);
        Debug.Log(playerDamage);
        ParentTakeDamage();
        phaseOne = false;
        PhaseTwo();
    }

    public void Beg()
    {
        dialogue.text = "Charlie uses beg";
        playerDamage = Random.Range(0, 5);
        Debug.Log(playerDamage);
        ParentTakeDamage();
        phaseOne = false;
        PhaseTwo();

    }

    public void PraiseGod()
    {
        dialogue.text = "Charlie uses preach";
        playerDamage = Random.Range(0, 5);
        Debug.Log(playerDamage);
        ParentTakeDamage();
        phaseOne = false;
        PhaseTwo();

    }

    public void Threaten()
    {
        dialogue.text = "Charlie uses threaten";
        playerDamage = Random.Range(0, 5);
        Debug.Log(playerDamage);
        ParentTakeDamage();
        phaseOne = false;
        PhaseTwo();

    }

    public void PityParty()
    {
        dialogue.text = "Charlie uses Pity Party";
        playerDamage = Random.Range(0, 5);
        Debug.Log(playerDamage);
        ParentTakeDamage();
        phaseOne = false;
        PhaseTwo();

    }

    public void RatShapeshift()
    {
        dialogue.text = "Charlie uses Rat shapeshifting";
        playerDamage = Random.Range(0, 5);
        Debug.Log(playerDamage);
        ParentTakeDamage();
        phaseOne = false;
        PhaseTwo();

    }

    public void Murder()
    {
        dialogue.text = "Charlie uses murder";
        playerDamage = Random.Range(0, 5);
        Debug.Log(playerDamage);
        ParentTakeDamage();
        phaseOne = false;
        PhaseTwo();

    }

    public void FurSuit()
    {
        dialogue.text = "Charlie uses fursuit";
        playerDamage = Random.Range(0, 5);
        Debug.Log(playerDamage);
        ParentTakeDamage();
        phaseOne = false;
        PhaseTwo();

    }


    //parent moves

    public void Rejection()
    {
        dialogue.text = "The parents use rejection";
        parentDamage = Random.Range(0, 5);
        Debug.Log(parentDamage);
        PlayerTakeDamage();
        phaseOne = true;
        

    }

    public void Shame()
    {
        dialogue.text = "The parents use shame";
        parentDamage = Random.Range(0, 5);
        Debug.Log(parentDamage);
        PlayerTakeDamage();
        phaseOne = true;
        

    }

    public void Compliment()
    {
        dialogue.text = "The parents use compliment";
        parentDamage = Random.Range(0, 5);
        Debug.Log(parentDamage);
        PlayerTakeDamage();
        phaseOne = true;
        

    }

    public void Insult()
    {
         dialogue.text = "The parents use insult";
        parentDamage = Random.Range(0, 5);
        Debug.Log(parentDamage);
        PlayerTakeDamage();
        phaseOne = true;
        
       
    }


}
