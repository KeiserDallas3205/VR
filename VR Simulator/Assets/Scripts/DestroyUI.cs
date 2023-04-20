using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DestroyUI : MonoBehaviour
{
    public GameObject text;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            Destroy(text);
        }
    }
}
