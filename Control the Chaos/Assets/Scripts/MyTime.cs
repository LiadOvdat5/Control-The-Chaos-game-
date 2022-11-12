using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MyTime : MonoBehaviour
{
    [SerializeField] TMP_Text myText;

    float myTime = Timer.currentTimePass;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int myTimeInt = (int)myTime;
        myText.text = myTimeInt.ToString();
    }
}
