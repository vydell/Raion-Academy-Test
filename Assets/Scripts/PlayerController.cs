using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;

public class PlayerController : MonoBehaviour
{
    public float jumpForce;
    public float gravitySource= -9.98f;
    public float tilt;

    private Vector3 direction;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            direction = Vector3.up*jumpForce;
            Debug.Log("jump");
        }

        direction.y += gravitySource * Time.deltaTime;
        transform.position += direction * Time.deltaTime;

        Vector3 rotation = transform.eulerAngles;
        rotation.z = direction.y * tilt;
        transform.eulerAngles = rotation;
    }
}
