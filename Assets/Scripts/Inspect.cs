using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Inspect : MonoBehaviour
{
    //Global Space
    public string userText = "";
    public int userNumber = 0;
    private Text _textBox;

    // Start is called before the first frame update
    void Start()
    {
        _textBox = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        _textBox.text = userNumber.ToString();
    }
}
