using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildObjects : MonoBehaviour
{
    
    // Global Variable
    public GameObject environmentObject;
    
    // Start is called before the first frame update
    void Start()
    {
        // Display Information 
        for (int i = 0; i < environmentObject.transform.childCount; i += 2)
        {
            Debug.Log("Sphere " + i +" - " + environmentObject.transform.GetChild(i).position);
            environmentObject.transform.GetChild(i).gameObject.SetActive(false);
        }
        
    } // Start()
    

    // Update is called once per frame
    void Update()
    {
        
    } // Update()
    
    
} // class
