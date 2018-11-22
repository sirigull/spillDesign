using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    /* Basic script for loading, and reloading, scenes
    */
	public void loadScene(string sceneName){
		SceneManager.LoadScene (sceneName);
	}

	public void reloadScene(){
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
	}


    public void QuitGame()
    {
        Application.Quit();
    }
}
