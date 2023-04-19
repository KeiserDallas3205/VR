using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
   // Reference to sound clips
	public AudioSource tool_falling;
	public AudioSource player_walking;
	public AudioSource component_falling;
	
	
	// When a gameobject makes contact
	private void OnCollisionEnter(Collision c)
	{
		// Player Walking
		if(c.gameObject.CompareTag("Player"))
		{
			player_walking.Play();
			
		}else if(c.gameObject.layer == LayerMask.NameToLayer("Tools"))
		{
			tool_falling.Play();
	
		}else if(c.gameObject.layer == LayerMask.NameToLayer("Components"))
		{
			component_falling.Play();
		}
	}

}
