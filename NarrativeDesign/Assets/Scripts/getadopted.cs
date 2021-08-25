using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class getadopted : MonoBehaviour
{
   
    public GameObject player;
    public GameObject parent;
    public int currentHealthPlayer;
    public int currentHealthParent;

    public GameObject winScreen;
    public GameObject loseScreen;

    public bool phaseOne, phaseTwo;
    public GameObject[] playerMoves;
    public 

    void Start()
    {
        
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

    public void PhaseOne()
    {
        //pick a set of 
    }

    public void PhaseTwo()
    {
        
    }





    public void Cry()
    {
        //what the move does anddd what parent move is associated with it 
    }

    public void Beg()
    {

    }

    public void PraiseGod()
    {
        
    }

    public void Threaten()
    {

    }

    public void PityParty()
    {

    }

    public void RatShapeshift()
    {

    }

    public void Murder()
    {

    }

    public void FurSuit()
    {

    }


    //parent moves

    public void Rejection()
    {

    }

    public void Shame()
    {

    }

    public void Complain()
    {

    }

    public void Insult()
    {

    }


}
