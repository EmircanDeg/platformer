using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonanimasyonscript : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    public void oynat() 
    {
        animator.Play("cannonanim");
        Invoke("animsifirla", 0.3f);
    }
    void animsifirla() { animator.Play("default"); }
    void Update()
    {
        
    }
}
