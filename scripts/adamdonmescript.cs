using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class adamdonmescript : MonoBehaviour
{
    public Joystick joystick;
    Vector3 harekat;
    float moveHorizontal;
    float moveVertical;

    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        moveHorizontal = joystick.Horizontal;
        moveVertical = joystick.Vertical;
        harekat = new Vector3(moveHorizontal, 0.0f, moveVertical);
        float angle = Mathf.Atan2(harekat.z, harekat.x) * Mathf.Rad2Deg;
        angle = angle-90;
        if(harekat != Vector3.zero) { transform.eulerAngles = new Vector3(0, -angle, 0); }
        
    }
    void Update()
    {
        
    }
}
