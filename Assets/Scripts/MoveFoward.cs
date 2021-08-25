using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFoward : MonoBehaviour
{
    // Start is called before the first frame update
    public int acceleration;
    public int turnSpeed;
    public GameObject explodes;
    void Start()
    {
        acceleration = 10;
        turnSpeed = 20;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, (Input.GetAxis("Vertical") * acceleration * Time.deltaTime));
        transform.Rotate(0, (Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime), 0.0f, Space.World);
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name.Equals("Blow_Up"))
        {
            explodes.gameObject.SetActive(true);
            explodes.GetComponent<ParticleSystem>().Play();
        }
    }
}
