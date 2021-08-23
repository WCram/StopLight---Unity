using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopLight : MonoBehaviour
{
    public GameObject stopLights;
    
    // Start is called before the first frame update
    void Start()
    {
        TurnOnRandom();
    } // Start()

    // Update is called once per frame
    void Update()
    {
        
    } // Update()

    public void TurnOffLights()
    {
        for (int i = 0; i < stopLights.transform.childCount; i++)
        {
            stopLights.transform.GetChild(i).transform.gameObject.SetActive(false);   
        }
    } // TurnOffLights()

    public void TurnOnRandom()
    {
        TurnOffLights();
        
        stopLights.transform.GetChild(Random.Range(0, stopLights.transform.childCount)).gameObject.SetActive(true);
    } // TurnOnRandom()
    
} // class
