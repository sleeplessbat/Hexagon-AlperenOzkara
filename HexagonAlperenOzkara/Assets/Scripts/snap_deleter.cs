﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snap_deleter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "snap_destroyer") {
            Destroy(gameObject);
        }
    }
}
