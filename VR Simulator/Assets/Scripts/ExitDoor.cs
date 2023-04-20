using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ExitDoor : MonoBehaviour
{
  
	void OnCollisionEnter(Collision c)
	{
		if(c.gameObject.CompareTag("Player"))
		{
			Application.Quit();
		}
	}
}
