using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runner : MonoBehaviour
{
    public float moveSpeed = 1;

    Rigidbody2D rb;
    OrderPoint[] orderPoints;
    int orderPointSelected;
    RunnerInstantiater instantiater;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        orderPoints = FindObjectsOfType<OrderPoint>();
        orderPointSelected = Random.Range(0, orderPoints.Length);
        instantiater = FindObjectOfType<RunnerInstantiater>();
    }

    // Update is called once per frame
    void Update()
    {

        rb.velocity = new Vector2(orderPoints[orderPointSelected].transform.position.x * moveSpeed, orderPoints[orderPointSelected].transform.position.y * moveSpeed);

        
    }

    public void ResetPos()
    {
        transform.position = instantiater.transform.position;
    }
}
