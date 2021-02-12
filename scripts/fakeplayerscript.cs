using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fakeplayerscript : MonoBehaviour
{
    GameObject player;
    float yfarki;
    void Start()
    {
        player = GameObject.Find("Player");
        yfarki = transform.position.z - player.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position;
    }
}
