using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ExitDoor : MonoBehaviour
{
  
	void OnTriggerEnter(Collider c)
	{
		if(c.CompareTag("Player"))
		{
			Application.Quit();
		}
	}
}
