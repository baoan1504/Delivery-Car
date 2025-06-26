using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collsions : MonoBehaviour
{

    bool hasPackage = false;
    [SerializeField] float DestroyDelay = 0.5f;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("oh gói hàng");
            hasPackage = true;
            Destroy(other.gameObject, DestroyDelay);
        }
        if (other.tag == "Location" && hasPackage)
        {
            Debug.Log("I receive package");
            hasPackage = false;
        }
    }
}
