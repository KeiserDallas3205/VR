using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Scene name to change to
    public string room;

    private void OnTriggerEnter(Collider collider)
    {
        // Otherwise -> go to next room
        if (collider.CompareTag("Player"))
        {
            SceneManager.LoadScene(room);
        }
    }
	
	public void changeScene(int sceneID) {
		SceneManager.LoadScene(sceneID);
		print("Changed scene");
	}

    public void PlayAgain()
    {
        SceneManager.LoadScene(room);
    }


    public void Quit()
    {
        Application.Quit();
    }
}
