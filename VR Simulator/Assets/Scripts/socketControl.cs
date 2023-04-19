using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using TMPro;

public class socketControl : MonoBehaviour
{
    public XRSocketInteractor socket;
    public TextMeshPro text;
    public GameObject correctText;
    public GameObject incorrect;
    public Rigidbody rb;

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

        if (obj.CompareTag("CubeAttachTest"))
        {
            correctText.SetActive(true);
            text.enabled = true;
            Debug.Log("correct thing attached!");
            print("correct thing attached");
            rb.constraints = RigidbodyConstraints.FreezeAll;
        }
        else 
        {
            incorrect.SetActive(true);
            text.enabled = false;
            Debug.Log("wrong thing attached...");
            print("wrong thing attached");
        }

    }
}
