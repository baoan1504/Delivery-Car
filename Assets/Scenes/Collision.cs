using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collsion : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("touching");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package")
        {
            Debug.Log("oh gói hàng");
        }
        if (other.tag == "Location")
        {
            Debug.Log("I receive package");
        }
    }
}
