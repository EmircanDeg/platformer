using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kanontopscript : MonoBehaviour
{
    Rigidbody rigid;
    public bool sagami = true;
    public bool ilerigeri = false;
    public bool ilerimi = true;
    public GameObject efekt;
    float atimguc;
    public GameObject suefekt;
    void Start()
    {
        atimguc = Random.Range(1250, 2250);
        rigid = gameObject.GetComponent<Rigidbody>();
        if (ilerigeri == false)
        {
            if (sagami == true) { rigid.AddForce(atimguc, 0, 0); }
            if (sagami == false) { rigid.AddForce(-atimguc, 0, 0); }
        }
        if (ilerigeri == true)
        {
            if (ilerimi == true) { rigid.AddForce(0, 0, atimguc); }
            if (ilerimi == false) { rigid.AddForce(0, 0, -atimguc); }
        }

        Invoke("olme", 2);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "olum") { Instantiate(suefekt, transform.position, Quaternion.Euler(90,0,0));Destroy(gameObject); }
    }

    void olme() 
    {
        Instantiate(efekt, transform.position, transform.rotation);
        Destroy(gameObject);
    }
    void Update()
    {
        
    }
}
