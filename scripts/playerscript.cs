using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscript : MonoBehaviour
{
    Rigidbody rigid;
    public Joystick joystick;
    float moveHorizontal;
    float moveVertical;
    public float hiz = 1f;
    public float gucsinir;
    bool ziplarmi = false;
    public float ziplamaguc;
    bool vantilat = false;
    bool vantilatsolda = false;
    bool vantilatarka = false;
    float engelguc;
    public Vector3 checkpoint;
    public GameObject carpmaefekt;
    public GameObject ziplaefekt;
    public GameObject suefekt;
    public GameObject adam;
    bool yurusun = true;
    
    
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody>();
        
    }

    void teleport() { rigid.velocity = Vector3.zero; transform.position = checkpoint; }
    private void FixedUpdate()
    {
        
        moveHorizontal = joystick.Horizontal;
        moveVertical = joystick.Vertical;
        Vector3 harekat = new Vector3(moveHorizontal, 0.0f, moveVertical);
        if (ziplarmi == true) { rigid.AddForce(harekat * hiz); }
        if (ziplarmi == false) { rigid.AddForce(harekat * (hiz-32f)); }
        if (vantilat == true) { rigid.AddForce(-9, 0, 0); }
        if (vantilatsolda == true) { rigid.AddForce(9, 0, 0); }
        if (vantilatarka == true) { rigid.AddForce(0, 0, -9); }
    }
    public void zipla() 
    { 
        if (ziplarmi == true)
        {
            Instantiate(ziplaefekt,transform.position-new Vector3(0,0.75f,0),transform.rotation); 
            rigid.AddForce(0,ziplamaguc,0);
            adam.GetComponent<Animator>().Play("jump");
        } 
    }
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "yer") 
        { 
            ziplarmi = true;
            if (yurusun == true) { adam.GetComponent<Animator>().Play("run"); }
            
        }
        if (collision.gameObject.tag == "engel") 
        {
            yurusun = false;
            adam.GetComponent<Animator>().Play("hit");
            Invoke("kosmaanim", 1.1f);
            Instantiate(carpmaefekt, transform.position, transform.rotation);
            engelguc = collision.gameObject.GetComponent<engelgucscript>().guc;
            rigid.AddForce(collision.contacts[0].normal.x*engelguc, collision.contacts[0].normal.y * engelguc, collision.contacts[0].normal.z*engelguc); 
        }
    }
    void kosmaanim() { adam.GetComponent<Animator>().Play("run");yurusun = true; }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "yer") { ziplarmi = false; }
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "yer") { ziplarmi = true; }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "vantilat") { vantilat = true; }
        if (other.gameObject.tag == "vantilatarka") { vantilatarka = true; }
        if (other.gameObject.tag == "vantilatsolda") { vantilatsolda = true; }
        if (other.gameObject.tag == "olum") {Instantiate(suefekt,transform.position,Quaternion.Euler(90,0,0)); Invoke("teleport",1); }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "vantilat") { vantilat = false; }
        if (other.gameObject.tag == "vantilatsolda") { vantilatsolda = false; }
        if (other.gameObject.tag == "vantilatarka") { vantilatarka = false; }
    }
}
