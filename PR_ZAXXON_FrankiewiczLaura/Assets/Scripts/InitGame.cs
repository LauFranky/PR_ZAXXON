using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InitGame : MonoBehaviour
{
    public float gatoSpeed = 30f;
    public bool alive;

    // Update is called once per frame
    void Update()
    {
        gatoSpeed += 0.001f;
        float veloc = (gatoSpeed * 3600) / 1000;
        //speedText.text = "S: " + Mathf.Round(veloc) + "Km/h";

    }
}
