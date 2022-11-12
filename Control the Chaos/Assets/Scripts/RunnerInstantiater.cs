using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerInstantiater : MonoBehaviour
{
    public int numOfRunners = 1;

    [SerializeField] GameObject runner;
    [SerializeField] float seconds = 5;
    float timeBetweenSpawn;

    Timer timer;

    private void Start()
    {
        timeBetweenSpawn = seconds;
        timer = FindObjectOfType<Timer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer.currentTime > timeBetweenSpawn)
        {
            timeBetweenSpawn += 3;
            Instantiate(runner);
        }
    }

    
}
