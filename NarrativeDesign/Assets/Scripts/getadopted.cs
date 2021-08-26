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


    public GameObject winScreen;
    public GameObject loseScreen;

    public bool phaseOne, phaseTwo;
    public GameObject[] playerMoves;
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
        
        if (phaseOne == true && phaseTwo == false)
        {
            PhaseOne();
        }
        if (phaseTwo == true && phaseOne == false)
        {
            PhaseTwo();
        }

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
        currentHealthParent -= 1;
    }

    public void PlayerTakeDamage()
    {
        currentHealthPlayer -= 1;
        //need to incorperate health bars still
    }
    public void PlayerHeal()
    {
        currentHealthPlayer += 1;
        //health bar
    }

    public void PhaseOne()
    {
        //pick a move from list to display as a button

    }

    public void PhaseTwo()
    {
        //pick parent move from list
    }





    public void Cry()
    {
        dialogue.text = "";

        phaseOne = false;
        phaseTwo = true;
    }

    public void Beg()
    {
        dialogue.text = "";
        phaseOne = false;
        phaseTwo = true;
    }

    public void PraiseGod()
    {
        dialogue.text = "";
        phaseOne = false;
        phaseTwo = true;
    }

    public void Threaten()
    {
        dialogue.text = "";
        phaseOne = false;
        phaseTwo = true;
    }

    public void PityParty()
    {
        dialogue.text = "";
        phaseOne = false;
        phaseTwo = true;
    }

    public void RatShapeshift()
    {
        dialogue.text = "";
        phaseOne = false;
        phaseTwo = true;
    }

    public void Murder()
    {
        dialogue.text = "";
        phaseOne = false;
        phaseTwo = true;
    }

    public void FurSuit()
    {
        dialogue.text = "";
        phaseOne = false;
        phaseTwo = true;
    }


    //parent moves

    public void Rejection()
    {
        dialogue.text = "";
        phaseOne = true;
        phaseTwo = false;
    }

    public void Shame()
    {
        dialogue.text = "";
        phaseOne = true;
        phaseTwo = false;
    }

    public void Complain()
    {
        dialogue.text = "";
        phaseOne = true;
        phaseTwo = false;
    }

    public void Insult()
    {
        dialogue.text = "";
        phaseOne = true;
        phaseTwo = false;
    }


}
