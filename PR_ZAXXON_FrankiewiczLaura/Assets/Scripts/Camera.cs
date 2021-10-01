using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] Transform player;
    private float zoffset;
    private float yoffset;

    //Start
    private void Start()
    {
        zoffset = 20f;
        yoffset = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.position.x, player.position.y + yoffset, player.position.z -zoffset);
    }
}
