using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class donenyuvarlakobstakllar : MonoBehaviour
{
    public GameObject donen;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = donen.transform.rotation;
    }
}
