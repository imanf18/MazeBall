using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonActionGameOver : MonoBehaviour
{
    public void ClickRetry()
    {
        Debug.Log("Retry");
        SceneManager.LoadScene("MazeBall");
    }

    public void ClickMainMenu()
    {
        Debug.Log("Main Menu");
        SceneManager.LoadScene("MainMenu");
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
