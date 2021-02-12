using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lolipopdonme : MonoBehaviour
{
    Rigidbody rigid;
    public float hiz;
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody>();
        rigid.angularVelocity= new Vector3(0,0,hiz);
        hiz = Random.Range(hiz - 1, hiz + 1);
    }

    // Update is called once per frame
    void Update()
    {
        rigid.angularVelocity = new Vector3(0, 0, hiz);
    }
}
