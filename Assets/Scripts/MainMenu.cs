using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{

    void Start()
    {
        // Ensure the cursor is visible and not locked
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void GoToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void QuitApp()
    {
        Application.Quit();
        Debug.Log("Application has quit");
    }
}
