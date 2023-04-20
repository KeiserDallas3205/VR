using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowUI : MonoBehaviour
{
    public GameObject showThisText;
    public TextMeshProUGUI showText;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            showThisText.SetActive(true);
            showText.enabled = true;
        }
    }
}
