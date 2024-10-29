using System;
using UnityEngine;

public class CustomSquareScript : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake from CustomSquareScript!");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello from CustomSquareScript!");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update from CustomSquareScript!");
    }
}
