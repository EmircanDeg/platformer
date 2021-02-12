using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secipcikartma : MonoBehaviour
{
    public GameObject[] objeler;
    public float cikarmazaman = 0;
    int secim;
    void Start()
    {
        Invoke("cikar", cikarmazaman);
    }

    
    void cikar() 
    {
        secim = Random.Range(0, objeler.Length);
        objeler[secim].SetActive(true);
    }
    void Update()
    {
        
    }
}
