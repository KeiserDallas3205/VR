using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.Events;
using Unity.VisualScripting;

public class TESTsocketTagCheck : MonoBehaviour
{
    // Socket component for object
    private XRSocketInteractor socket;

    // Tag of the correct object
    [SerializeField] public string correctComponent;

    public UnityEvent onSelectEntered;
    public UnityEvent onSelectExited;

    void Start()
    {
        // Get the socket component from game object
        socket = GetComponent<XRSocketInteractor>();

    }

    void showTheText(XRGrabInteractable grabbable)
    {
        if (grabbable.gameObject.CompareTag(correctComponent))
        {
            onSelectEntered.Invoke();
        }
    }


}
