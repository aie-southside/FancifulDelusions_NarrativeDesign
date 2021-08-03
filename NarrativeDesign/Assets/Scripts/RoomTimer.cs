using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTimer : MonoBehaviour
{
    public int TimeBeforeActivate;
    public GameObject[] ObjectsToActivateR;  
    public GameObject[] ObjectsToDeactivateR;  
    public GameObject[] ObjectsToActivateI;  
    public GameObject[] ObjectsToDeactivateI;
    private bool R;
    private bool I;

    void Start()
    {
        StartCoroutine(ChangeRooms());
        R = true;
        I = false;
    }

 

    public IEnumerator ChangeRooms()
    {
        if(R == true)
        {

            yield return new WaitForSeconds(5);

            foreach (GameObject obj in ObjectsToActivateR)
            {
                obj.SetActive(true);
            }

            foreach (GameObject obj in ObjectsToDeactivateR)
            {
                obj.SetActive(false);
            }
        }
        if (I == true)
        {
            yield return new WaitForSeconds(5);

            foreach (GameObject obj in ObjectsToActivateI)
            {
                obj.SetActive(true);
            }

            foreach (GameObject obj in ObjectsToDeactivateI)
            {
                obj.SetActive(false);
            }
            
        }
        RestartCoroutine();
    }

    public void RestartCoroutine()
    {
        I = !I;
        R = !R;
        StartCoroutine(ChangeRooms());
       
    }


}
