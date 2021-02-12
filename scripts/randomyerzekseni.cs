using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomyerzekseni : MonoBehaviour
{
    float zsec;
    public float eksiz = 0;
    void Start()
    {
        zsec = Random.Range(-7+eksiz, 7-eksiz);
        transform.position = transform.position + new Vector3(0, 0, zsec);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
