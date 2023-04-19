using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public float moveSpeed;

    public Transform orientation;

    float horzontalInput;
    float verticalInput;

    Vector3 moveDirection;

    Rigidbody rb;

    private void update()
    {
        MyInput();
    }

    private void MyInput()
    {
        horzontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }
}
