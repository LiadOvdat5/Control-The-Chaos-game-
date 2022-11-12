using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderPoint : MonoBehaviour
{
    GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Runner")
        {
            Destroy(collision.gameObject);
            gameManager.RemoveRunner();
        }
    }
}
