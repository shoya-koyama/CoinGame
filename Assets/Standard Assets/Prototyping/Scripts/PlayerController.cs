using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // speed�𐧌䂷��
    public float speed = 10;
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        // x��z��speed���|����
        rigidbody.AddForce(x * speed, 0, z * speed);
    }
}
