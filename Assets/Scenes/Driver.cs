using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0.1f;

    [SerializeField] float steerSpeed = 0.2f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // trả về các giá trị từ khoảng -1 đến 1, và sẽ 0 khi không có tác động
        float changeSteer = Input.GetAxis("Horizontal") *steerSpeed *Time.deltaTime;
        float changeMove = Input.GetAxis("Vertical") * moveSpeed *Time.deltaTime;
        transform.Translate(0, changeMove, 0);
        transform.Rotate(0, 0, -changeSteer);
    }
}
