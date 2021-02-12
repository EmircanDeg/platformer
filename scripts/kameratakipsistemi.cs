using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameratakipsistemi : MonoBehaviour
{
    public GameObject player;
    public Transform transforom;
    float zfarki;
    void Start()
    {
        transforom = player.transform;
        zfarki = transform.position.z - player.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(transforom);
        transform.position = new Vector3(0, transform.position.y, player.transform.position.z + zfarki);
    }
}
