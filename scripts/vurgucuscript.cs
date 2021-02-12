using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vurgucuscript : MonoBehaviour
{
    public float ileriguc;
    public float geriguc;
    Rigidbody rigid;
    bool ilerimi = true;
    public bool sagsolmu = false;
    bool basla = false;
    float baslayis;
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody>();
        baslayis = Random.Range(0, 2);
        Invoke("baslatici", baslayis);
    }

    void baslatici() { basla = true; }
    private void FixedUpdate()
    {
        if (basla == true) 
        {
            if (sagsolmu == false)
            {
                if (ilerimi == true) { rigid.velocity = new Vector3(-ileriguc, 0, 0); }
                if (ilerimi == false) { rigid.velocity = new Vector3(geriguc, 0, 0); }
            }
            if (sagsolmu == true)
            {
                if (ilerimi == true) { rigid.velocity = new Vector3(0, 0, ileriguc); }
                if (ilerimi == false) { rigid.velocity = new Vector3(0, 0, -geriguc); }
            }
        }
        

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "arka") { ilerimi = true; }
        if (other.gameObject.tag == "on") { ilerimi = false; }
    }
    void Update()
    {
        
    }
}
