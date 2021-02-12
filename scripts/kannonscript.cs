using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kannonscript : MonoBehaviour
{
    public GameObject top;
    public GameObject cannon;
    float zaman = 1;
    void Start()
    {
        Invoke("topcikar", zaman);

    }

    public void topcikar() 
    {
        cannon.GetComponent<cannonanimasyonscript>().oynat();
        Instantiate(top, transform.position, transform.rotation);
        zaman = Random.Range(1f, 2.2f);
        Invoke("topcikar", zaman);
    }
    void Update()
    {
        
    }
}
