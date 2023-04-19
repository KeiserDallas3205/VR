using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checkpoint : MonoBehaviour
{
	// Reference to current scene -> checkpoint
	private string currentScene;
	
	// Reference to checkpoint
	private string checkpoint;
	
	// Reference to default checkpoint
	private string defaultCheckpoint = "Room1";
	
   
	public void Save(){
		// Get the current scene 
		currentScene = SceneManager.GetActiveScene().name;
		
		// Save the current scene as checkpoint 
		PlayerPrefs.SetString("checkpoint",currentScene);
	}
   
   
	public void Load(){
		// Retrieve the last checkpoint 
		//	-- Default checkpoint is the first scene
		checkpoint = PlayerPrefs.GetString("checkpoint",defaultCheckpoint);
	  
		// Load game to that checkpoint 
		SceneManager.LoadScene(checkpoint);
	  
	}
   
}
