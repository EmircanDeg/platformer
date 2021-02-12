using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ucgenbumperanimscript : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    void sifirla() { anim.Play("default"); }
    void oynat() { anim.Play("ucgenbumperanim"); Invoke("sifirla", 0.2f); }
    private void OnCollisionEnter(Collision collision)
    {
        //if (collision.gameObject.tag == "Player") { oynat(); }
    }
}
