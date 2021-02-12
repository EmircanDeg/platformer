using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tataravelascript : MonoBehaviour
{
    public bool yanmi = true;
    Rigidbody rigid;
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody>();
        if (yanmi == true) { Invoke("yanduz", 0.25f); }
        if (yanmi == false) { Invoke("duzduz", 0.25f); }
    }

    void yanduz() 
    {
        rigid.velocity = Vector3.zero;
        rigid.angularVelocity = Vector3.zero;
        transform.rotation = Quaternion.Euler(90, 0, 0);
    }
    void duzduz() 
    {
        rigid.velocity = Vector3.zero;
        rigid.angularVelocity = Vector3.zero;
        transform.rotation = Quaternion.Euler(90,-90, 0);
    }
    void Update()
    {
        
    }
}
