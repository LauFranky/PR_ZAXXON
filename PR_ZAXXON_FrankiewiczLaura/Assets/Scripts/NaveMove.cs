using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NaveMove : MonoBehaviour
{
    public Transform navePos;
    [SerializeField] float desplSpeed;
    [SerializeField] float rotationSpeed;
    [SerializeField] GameObject laser;

    /*itGame initGame;*/
    [SerializeField] Image lifesImage;
    [SerializeField] Sprite[] lifesSprite;

    [SerializeField] GameObject cannon;


    //Variables para restriccion
    float limitH = 20f;
    float limitY = 25f;
    float suelo = 0.6f;

    
    // Start is called before the first frame update
    void Start()
    {
        desplSpeed = 50f;



       if(GameManager.playerLifes <= 0)
        {
            SceneManager.LoadScene(3);
            GameManager.playerLifes = 3;
        }
       int lifes = GameManager.playerLifes;
        lifesImage.sprite = lifesSprite[lifes];
    }


    // Update is called once per frame
    void Update()
    {
        MoverNave();
        Disparos();
    }

    /*

       if (posX > limitH && desplX > 0f)
       {
           transform.position = new Vector3(posX, transform.position.y, transform.position.z);
       }
       else if(posX < -limitH
       */

//Disparos//
void Disparos()
    {

        
        
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(laser, cannon.transform.position, Quaternion.identity);
            


        }
    }
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

    transform.rotation = Quaternion.Euler(desplY * -30, 0, desplX * -30);
    }

   private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 6)
        {
            GameManager.playerLifes--;
            if(GameManager.playerLifes == 0)
            {
                SceneManager.LoadScene(6);
            }
            else
            {
                int currentScene = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(currentScene);
            }
            
        }
    }


}
