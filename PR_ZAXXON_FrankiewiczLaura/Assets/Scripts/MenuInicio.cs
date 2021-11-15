using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuInicio : MonoBehaviour
{
    public void IniciarJuego()
    {
        SceneManager.LoadScene(0);
    }
    public void IniciarOptions()
    {
        SceneManager.LoadScene(4);
    }
    public void IniciarHighScore()
    {
        SceneManager.LoadScene(5);
    }
    public void IniciarMenuInicio()
    {
        SceneManager.LoadScene(3);
    }
}
