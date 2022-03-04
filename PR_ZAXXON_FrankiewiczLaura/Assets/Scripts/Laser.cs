using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Laser : MonoBehaviour
{
    float speed;

    AudioSource audioSource;
    [SerializeField] AudioClip explosionAudio;

    // Start is called before the first frame update
    void Start()
    {
        speed = 80f;

        audioSource = GetComponent<AudioSource>();
        audioSource.volume = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        float posZ = transform.position.z;
        if (posZ > 200f)
        {
            Destroy(gameObject);
           
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "rompible")
        {
            audioSource.Play();
            Destroy(other.gameObject);
            Destroy(gameObject, 5f);
            
        }
        else
        {
            audioSource.PlayOneShot(explosionAudio, 1f);
            Destroy(gameObject, 5f);
           
        }

    }
}
