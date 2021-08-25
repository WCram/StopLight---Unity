using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    
    // Global Space
    private Renderer rend;
    public Material[] mat;
    public int count = 0;
    private float timeRemaining = 3;
    // private BoxCollider _boxCollider;
    
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();

        
        // _boxCollider = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
  
    }

    public void Timer()
    {
              if (timeRemaining > 0)
                {
                    timeRemaining -= Time.deltaTime;
                }
                else
                {
                    ChangeColor();
                    timeRemaining = 3;
                }
    }
    public void ChangeColor()
    {
        count = (count < mat.Length - 1) ? count + 1 : 0;
        
        /*
         * if (count < mat.Length - 1) {
         *  count++;
         * }
         * else {
         * count = 0;
         */
        Debug.Log($"{count} - {mat[count]}");
        rend.material = mat[count];
    } // ChangeColor

    
} // class
