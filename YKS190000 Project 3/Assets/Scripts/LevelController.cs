using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ExitLevel();
        }

        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            LoadLevel();
        }
    }

    private void ExitLevel()
    {
        Application.Quit();
    }

    private void LoadLevel()
    {
        SceneManager.LoadScene("Level01");
    }
}
