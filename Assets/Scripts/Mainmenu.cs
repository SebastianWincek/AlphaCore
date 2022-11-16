using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
    
{
    public GameObject menu;
    // Start is called before the first frame update


    // Update is called once per frame
    public void Playgame()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1f;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
