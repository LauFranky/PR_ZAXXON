using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class InitGame : MonoBehaviour
{
    [SerializeField] Text score;
    public static int puntos;
    public GameObject gatete;
    public float desplSpeed;

    public static int numero = 0;
    public static int minuto = 0;
    public static int hora = 0;

    public float speed = 80f;


    // Start is called before the first frame update
    void Start()
    {
        puntos = 0;
        score.text = "score: " + puntos;
        speed = 80f;
        desplSpeed = 20f;
        StartCoroutine("contador");
    }

    // Update is called once per frame
   /* void Update()
    {
        if (GameManager.playerLifes == 0)
        {
            StopCoroutine("contador");
        }
    }*/


    private void OnTriggerEnter(Collider other)
    {
        puntos++;
        score.text = "score: " + puntos;
    }

    IEnumerator contador()
    {
        while (true)
        {
            //print(hora.ToString("D2") + ":" + minuto.ToString("D2") + ":" + numero.ToString("D2"));
            numero++;
            score.text = "Tiempo Sobrevivido " + hora.ToString("D2") + ":" + minuto.ToString("D2") + ":" + numero.ToString("D2");
            yield return new WaitForSeconds(1f);

            if (numero == 20)
                if (numero == 60)
                {
                    numero = 0;
                    minuto++;
                }
            if (minuto == 60)
            {
                minuto = 0;
                hora++;
            }
            if (hora == 23)
            {
                hora = 0;
            }
        }
    }
}


    /*public float gatoSpeed = 30f;
    public bool alive;

    // Update is called once per frame
    void Update()
    {
        gatoSpeed += 0.001f;
        float veloc = (gatoSpeed * 3600) / 1000;
        //speedText.text = "S: " + Mathf.Round(veloc) + "Km/h";

    }
}*/

