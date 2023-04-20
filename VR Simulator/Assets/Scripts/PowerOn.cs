using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerOn : MonoBehaviour
{
	// Reference to monitor panel
	public GameObject screen;
	
	
    void OnTriggerEnter(Collider c)
	{
		if(c.CompareTag("Player"))
		{
			screen.SetActive(true);
		}
	}
}
