using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class clearroom : MonoBehaviour
{
    private bool sink, sauce, toilet, bath, soap, crayons, cry, spaghetti, fridge, table, dad;
    public UnityEvent OnBathroomClear, OnSpyClear, OnKitchenClear;

    private bool blanket, lamp, blood, food;

    private bool hasRunSpy, hasRunKitchen;


   
    void Update()
    {
        if (sink == true && sauce == true && bath == true && crayons == true && toilet == true && soap == true && cry == true)
        {
            OnBathroomClear.Invoke();
        }
        if (blanket == true && lamp == true && food == true && blood == true && hasRunSpy == false)
        {
            OnSpyClear.Invoke();
            Debug.Log("found all the clues");
            hasRunSpy = true;
        }
        if (spaghetti == true && fridge == true && table == true && dad == true && hasRunKitchen == false)
        {
            OnKitchenClear.Invoke();
            hasRunKitchen = true;
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
        lamp = true;

    } 
    public void Blood()
    {
        blood = true;

    } 
    public void Food()
    {
        food = true;

    }

    public void Spaghetti()
    {
        spaghetti = true;
    }   
    public void Fridge()
    {
        fridge = true;
    }
    public void Table()
    {
        table = true;
    } 
    public void Dad()
    {
        dad = true;
        Debug.Log("dad true");
    }
    

}
