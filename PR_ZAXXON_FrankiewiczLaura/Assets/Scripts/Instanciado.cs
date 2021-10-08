using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instanciado : MonoBehaviour
{
    float intervalo;
    [SerializeField] GameObject obstaculos;
    [SerializeField] Transform initialPos;

    float desplX = 5f;


    // Start is called before the first frame update
    void Start()
    {
        intervalo = 0.1f;
        StartCoroutine("CrearObstaculos");
        Vector3 destPos = initialPos.position;
        Vector3 despl = new Vector3(desplX, 0, 0);

        /*for(int n = 0; n < 10; n++)
        {
            Instantiate(obstaculos, destPos, Quaternion.identity);
            destPos = destPos + despl;

        }
        */


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator CrearObstaculos()
    {
        while (true)
        {
            
            float randomX = Random.Range(-20f, 20f);
            float randomY = Random.Range(3f, 20f);
            Vector3 newPos = new Vector3(randomX, randomY, initialPos.position.z);
            Instantiate(obstaculos, newPos, Quaternion.identity);

            yield return new WaitForSeconds(intervalo);
        }

    }
}
