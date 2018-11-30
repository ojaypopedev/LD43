using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour {


    int thisScene;

    private void Start()
    {
        thisScene = SceneManager.GetActiveScene().buildIndex;
    }

    public void GoToScene(int Scene)
    {
        SceneManager.LoadScene(Scene);
    }

    public void ResetScene()
    {
        SceneManager.LoadScene(thisScene);
    }

   
}
