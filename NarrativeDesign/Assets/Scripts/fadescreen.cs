using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class fadescreen : MonoBehaviour
{
    public Image image;
    public float fadeSpeed = 1.5f;
   
    void Start()
    {
        image.color = Color.Lerp(image.color, Color.clear, fadeSpeed * Time.deltaTime);
    }


    
}
