using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yuvarlakplatformdonme : MonoBehaviour
{
    Rigidbody rigid;
    float hiz;

    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody>();
        hiz = Random.Range(0.5f, 1.5f);
    }

    private void FixedUpdate()
    {
        rigid.angularVelocity = new Vector3(0, hiz, 0);
    }
    void Update()
    {
        
    }
}
