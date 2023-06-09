using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using TMPro;

public class socketControl : MonoBehaviour
{
    public XRSocketInteractor socket;
    public GameObject correctText;
    public GameObject incorrect;
    public Rigidbody rb;
    public string tagName;

    // This is the object that would disappear upon socket snap
    //public GameObject grabbable;

    // Start is called before the first frame update
    void Start()
    {
        socket = GetComponent<XRSocketInteractor>();
        
    }

    public void socketCheck()
    {
        XRGrabInteractable obj = (XRGrabInteractable)socket.GetOldestInteractableSelected();
        rb = obj.GetComponent<Rigidbody>();

        if (obj.CompareTag(tagName))
        {
            correctText.SetActive(true);
            Debug.Log("correct thing attached!");
            print("correct thing attached");
            rb.constraints = RigidbodyConstraints.FreezeAll;
			socket.allowHover = false;
        }
        else 
        {
            incorrect.SetActive(true);
            Debug.Log("wrong thing attached...");
            print("wrong thing attached");
        }

    }
}
