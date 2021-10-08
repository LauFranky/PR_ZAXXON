using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveMove : MonoBehaviour
{
    [SerializeField] float desplSpeed;
    [SerializeField] float rotationSpeed;


    //Variables para restriccion
    float limitH = 14f;
    float limitY = 20f;
    float suelo = 0.6f;

    
    // Start is called before the first frame update
    void Start()
    {
        desplSpeed = 50f;
        rotationSpeed = 150f;
    }


    // Update is called once per frame
    void Update()
    {
        MoverNave();

    }

    /*

       if (posX > limitH && desplX > 0f)
       {
           transform.position = new Vector3(posX, transform.position.y, transform.position.z);
       }
       else if(posX < -limitH
       */


    // Movimientos de la nave
    void MoverNave()
    {
        float desplX = Input.GetAxis("Horizontal");
    float desplY = Input.GetAxis("Vertical");
    float desplR = Input.GetAxis("Rotation");
    float posX = transform.position.x;
    float posY = transform.position.y;

        if((posX < limitH || desplX< 0f) && (posX > -limitH || desplX > 0f))
        {
            transform.Translate(Vector3.right* Time.deltaTime* desplSpeed * desplX, Space.World);
        }

        if ((posY < limitY || desplY < 0f) && (posY > suelo || desplY > 0f))
        {
    transform.Translate(Vector3.up * Time.deltaTime * desplSpeed * desplY, Space.World);
        }

transform.Rotate(0f, 0f, desplR * Time.deltaTime * -rotationSpeed);
    }
}
