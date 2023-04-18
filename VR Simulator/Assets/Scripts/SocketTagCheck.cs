using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class SocketTagCheck : MonoBehaviour
{
	// Socket component for object
    private XRSocketInteractor socket;

	// Text to be displayed
	public GameObject correctText;
	public GameObject wrongText;
	
	// Tag of the correct object
	public string correctComponent;
	
	
	// Start is called before the first frame update
    void Start()
    {
		// Get the socket component from game object
		socket = GetComponent<XRSocketInteractor>();
		
		
    }

    void OnSelectEnter(XRBaseInteractable interactable)
	{
		if(interactable.gameObject.CompareTag(correctComponent))
			{
			// Accepted -> Display UI message to player
			print("Correct spot, good job!");
			correctText.SetActive(true);

		}else
		{
			// Denied -> Display UI message to user
			print("Wrong spot, try again.");
			wrongText.SetActive(true);
			
		}
	}
	
	
}
