using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    /// <summary>
    /// Loads the game scene
    /// </summary>
    public void loadgame()
    {
        SceneManager.LoadScene("GameScene");
    }

}
