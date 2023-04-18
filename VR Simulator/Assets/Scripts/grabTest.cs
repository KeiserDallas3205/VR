using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.Events;

public class grabTest : MonoBehaviour
{
    public TextMeshPro text;
    //[SerializeField] 
    public GameObject obj;
    public XRDirectInteractor hand;

    public UnityEvent onSelectEntered;

    public void showText(TextMeshPro text)
    {
        onSelectEntered.Invoke();
    }
}


/*
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshPro>();
        text.enabled = false;
    }

    void Update()
    {
        if (obj.grabbedBy == hand
    }
}
*/