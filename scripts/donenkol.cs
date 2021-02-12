using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class donenkol : MonoBehaviour
{
    Rigidbody rigid;
    public float donmehiz;
    int eksimi;
    void Start()
    {
        eksimi = Random.Range(0, 10);
        rigid = gameObject.GetComponent<Rigidbody>();
        donmehiz = Random.Range(2, 4);
        if (eksimi < 5) { donmehiz = -donmehiz; }
        rigid.angularVelocity = new Vector3(0,donmehiz,0);
    }

    // Update is called once per frame
    void Update()
    {
        rigid.angularVelocity = new Vector3(0, donmehiz, 0);
    }
}
