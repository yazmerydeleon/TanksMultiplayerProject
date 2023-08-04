using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float tankSpeed = 10.0f;
    [SerializeField] private float tankTurnSpeed = 10.0f;

    private Rigidbody tankRB;

    private float horizontal;
    private float vertical;
    
    void Start()
    {
        tankRB = GetComponent<Rigidbody>();
    }
  
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        tankRB.velocity = tankRB.transform.forward * tankSpeed * vertical;
        tankRB.rotation = Quaternion.Euler(transform.eulerAngles + transform.up * horizontal * tankSpeed);

    }
}
