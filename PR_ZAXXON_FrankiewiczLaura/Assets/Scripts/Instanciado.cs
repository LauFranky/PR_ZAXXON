using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instanciado : MonoBehaviour
{
    float intervalo;
    [SerializeField] GameObject[] obstaculos;
    [SerializeField] Transform initialPos;

    float desplX = 5f;


    // Start is called before the first frame update
    void Start()
    {
        intervalo = 0.5f;
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

    float RandomExclude(float excluir, float rango)
    {
        float returnNumber = excluir;
        float numIni = excluir - rango;
        float numFin = excluir + rango;

        while (returnNumber > numIni && returnNumber < numFin)
        {
            returnNumber = Random.Range(0f, 5f);
            float returnNumber2 = Random.Range(returnNumber, 10f);
        }
        return returnNumber;
    }


    IEnumerator CrearObstaculos()
    {
        while (true)
        {
            
            float randomX = Random.Range(-20f, 20f);
            float randomY = Random.Range(3f, 20f);
            Vector3 newPos = new Vector3(randomX, randomY, initialPos.position.z);
            int elemento = Random.Range(0, obstaculos.Length);
            Instantiate(obstaculos[elemento], newPos, Quaternion.identity);


            /* Genero un número aleatorio para elegir obstaculos*/
            int numAl = Random.Range(0, obstaculos.Length);
            Instantiate(obstaculos[numAl], newPos, Quaternion.identity);

            yield return new WaitForSeconds(intervalo);
        }

    }
}
