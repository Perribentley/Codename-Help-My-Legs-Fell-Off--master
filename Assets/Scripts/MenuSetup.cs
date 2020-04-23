using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSetup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    public void LevelSelect()
    {
        SceneManager.LoadScene(1);
    }

    public void Level1()
    {
        SceneManager.LoadScene(2);
    }

    public void Level2()
    {
        SceneManager.LoadScene(3);
    }

    public void Level3()
    {
        SceneManager.LoadScene(4);
    }

    public void LevelWin()
    {
        SceneManager.LoadScene(5);
    }

    public void GameWin()
    {
        SceneManager.LoadScene(6);
    }

    public void Lose()
    {
        SceneManager.LoadScene(7);
    }

    public void HowTo()
    {
        SceneManager.LoadScene(8);
    }
}
