using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIChanger : MonoBehaviour
{
    public GameObject uiThing;

    
    void Start()
    {
        uiThing.SetActive(false);
    }

    private void OnTriggerEnter(Collider hand)
    {
        if (hand.gameObject.tag == "Hand")
        { 
            uiThing.SetActive(true);
            StartCoroutine("WaitForSec");
        }
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(20);
        Destroy(uiThing);
    }
}
