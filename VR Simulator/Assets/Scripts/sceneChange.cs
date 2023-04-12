using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChange : MonoBehaviour
{
    
	public void changeScene(int sceneID) {
		SceneManager.LoadScene(sceneID);
		print("Changed scene");
	}
	
	public void quit(){
		print("bye");
		 Application.Quit();
	}
	
	public void load(){
		print("Load last save");
	}

}