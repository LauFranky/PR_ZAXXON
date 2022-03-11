using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void LoadScene(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }
    public void IniciarJuego()
    {
        GameManager.playerLifes = 3;
        GameManager.alive = true;
        SceneManager.LoadScene(0);
    }
}
