using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    RunnerInstantiater instantiater;
    int numOfRunners;
    int RemovedRunners;
    SceneLoader sceneLoader;


    // Start is called before the first frame update
    void Start()
    {
        instantiater = FindObjectOfType<RunnerInstantiater>();
        numOfRunners = instantiater.numOfRunners;
        RemovedRunners = 0;
        sceneLoader = FindObjectOfType<SceneLoader>();
    }

    // Update is called once per frame
    void Update()
    {
        if (RemovedRunners > (numOfRunners / 2))
        {
            Lose();
            
        }

    }

    public void RemoveRunner()
    {
        RemovedRunners++;
    }

    void Lose()
    {
        sceneLoader.LoadNextScene();
    }

}
