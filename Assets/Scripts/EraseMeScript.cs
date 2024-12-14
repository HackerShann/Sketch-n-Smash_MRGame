using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EraseMeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 40f);
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider WhatHit)
    {
        if (WhatHit.gameObject.CompareTag("eraser"))
        {
            Destroy(this.gameObject);
        }
    }
}
