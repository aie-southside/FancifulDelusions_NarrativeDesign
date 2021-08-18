using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class clearroom : MonoBehaviour
{
    private bool sink, sauce, toilet, bath, soap, crayons, cry;
    public UnityEvent OnBathroomClear, OnSpyClear;

    private bool blanket, lamp, blood, food;

    void Start()
    {
        
    }

   
    void Update()
    {
        if (sink == true && sauce == true && bath == true && crayons == true && toilet == true && soap == true && cry == true)
        {
            OnBathroomClear.Invoke();
        }
        if (blanket == true && lamp == true && food == true && blood == true)
        {
            OnSpyClear.Invoke();
            Debug.Log("found all the clues");
        }
    }

    public void Sink()
    {
        sink = true;
    }
    public void Sauce()
    {
        sauce = true;
    }
    public void Bath()
    {
        bath = true;
    }
    public void Crayons()
    {
        crayons = true;
    }
    public void Toilet()
    {
        toilet = true;
    }
    public void Soap()
    {
        soap = true;
    } 
    public void Cry()
    {
        cry = true;
    }


    public void Blanket()
    {
        blanket = true;

    } 
    public void Lamp()
    {
        blanket = true;

    } 
    public void Blood()
    {
        blanket = true;

    } 
    public void Food()
    {
        blanket = true;

    }

}
