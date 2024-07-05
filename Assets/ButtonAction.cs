using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonAction : MonoBehaviour
{
    public void ClickStart()
    {
        Debug.Log("Start");
        SceneManager.LoadScene("MazeBall");
    }

    public void ClickQuit()
    {
        Debug.Log("Quit");
        Application.Quit();
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
