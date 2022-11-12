using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    public float startTime = 00f;
    public Text countText;

    public float currentTime = 0f;
    SceneLoader sceneLoader;

    public static float currentTimePass;


    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
        sceneLoader = FindObjectOfType<SceneLoader>();
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += 1 * Time.deltaTime;
        countText.text = currentTime.ToString("0");

        currentTimePass = currentTime;
       
    }
}
