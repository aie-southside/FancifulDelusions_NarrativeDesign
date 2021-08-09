using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class clearroom : MonoBehaviour
{
    private bool sink, sauce, toilet, bath, soap, crayons;
    public UnityEvent OnBathroomClear;

    void Start()
    {
        
    }

   
    void Update()
    {
        if (sink == true && sauce == true && bath == true && crayons == true && toilet == true && soap == true)
        {
            OnBathroomClear.Invoke();
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
}
