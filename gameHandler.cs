using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void PlayGame()
    {
        SceneManagement.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    
    }
    public void QuitGame ()
    {
        Debug.Log("QUIT");
        Application.Quit();

    }

}
