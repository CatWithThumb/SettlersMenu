using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartUpMenu : MonoBehaviour
{
    private int TotalPlayerNum = 1;
    public Button PlayButton;
    PlayerNumScript playerNumScript;
    CpuNumScript cpuNumScript;

    void Awake()
    {
        playerNumScript = GameObject.Find("StartUpMenu").GetComponent<PlayerNumScript>();
        cpuNumScript = GameObject.Find("StartUpMenu").GetComponent<CpuNumScript>();
    }
    
    void Start()
    {
        PlayButton.interactable = false;
    }

    void Update()
    {
        TotalPlayerNum = cpuNumScript.NumCpuPlayers + playerNumScript.NumHumanPlayers;
        if ((TotalPlayerNum < 2) || (TotalPlayerNum > 4))
        {
            PlayButton.interactable = false;
        }
        else
        {
            PlayButton.interactable = true;
        }

    }

    
    //Load Scene
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //Quit Game
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Player quit from startup menu");
    }
}
