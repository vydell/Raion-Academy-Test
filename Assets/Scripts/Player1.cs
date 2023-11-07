using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public float jumpForce;
    public float gravitySource = -9.98f;
    public float tilt;
    public float powerUpDuration;
    private Animator anim;
    private Rigidbody2D rb;
    private bool isPowerUp;

    private Vector3 direction;
    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            direction = Vector3.up * jumpForce;
        }

        direction.y += gravitySource * Time.deltaTime;
        transform.position += direction * Time.deltaTime;

        Vector3 rotation = transform.eulerAngles;
        rotation.z = direction.y * tilt;
        transform.eulerAngles = rotation;

        if (Input.GetKeyDown(KeyCode.P) && !isPowerUp)
        {
            StartCoroutine(PowerUp());
        }
    }

    IEnumerator PowerUp()
    {
        isPowerUp = true;
        rb.isKinematic = true;

        anim.SetTrigger("Power up");
        yield return new WaitForSeconds(powerUpDuration);
        anim.SetTrigger("Normal");

        isPowerUp = false;
        rb.isKinematic = false;

        StopAllCoroutines();
    }


}
