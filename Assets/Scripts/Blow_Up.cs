using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blow_Up : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag.Equals("Player"))
            {
                Debug.Log(other.gameObject.name);
                other.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(100,100,100), ForceMode.Impulse);
            }
        
    }
}
