using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collsions : MonoBehaviour
{
    bool hasPackage = false;
    [SerializeField] float DestroyDelay = 0.5f;
    [SerializeField] Color32 PackageColor = new Color32(255, 1, 1, 255);
    [SerializeField] Color32 noPackageColor = new Color32(255, 255, 255, 255);
    SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("oh gói hàng");
            hasPackage = true;
            spriteRenderer.color = PackageColor;
            Destroy(other.gameObject, DestroyDelay);
        }
        if (other.tag == "Location" && hasPackage)
        {
            Debug.Log("I receive package");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
