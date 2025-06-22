using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collsion : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("touching");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("you pass the circle");
    }
}
