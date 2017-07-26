using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    float angle;
    float smoothInputMagnitude;
    float smoothMoveVelocity;
    Rigidbody rbPlayer;
    Vector3 velocity;
    Animator animControl;

    public float moveSpeed = 3;
    public float smoothMoveTime = 0.1f;
    public float turnSpeed = 8;

    private void Start()
    {
        rbPlayer = GetComponent<Rigidbody>();
        animControl = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update () {
        Vector3 inputDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;
        float inputMagnitude = inputDirection.magnitude;
        animControl.SetFloat("MoveInput", inputMagnitude);
        smoothInputMagnitude = Mathf.SmoothDamp(smoothInputMagnitude, inputMagnitude, ref smoothMoveVelocity, smoothMoveTime);

        float targetAngle = Mathf.Atan2(inputDirection.x, inputDirection.z) * Mathf.Rad2Deg;
        angle = Mathf.LerpAngle(angle, targetAngle, Time.deltaTime * turnSpeed * inputMagnitude);
        

        velocity = transform.forward * moveSpeed 
                                     * smoothInputMagnitude;

        if (Input.GetKey(KeyCode.F))
        {
            animControl.SetTrigger("TossCoin");
        }
    }

    private void FixedUpdate()
    {
        rbPlayer.MoveRotation(Quaternion.Euler(Vector3.up * angle));
        rbPlayer.MovePosition(rbPlayer.position + velocity * Time.fixedDeltaTime);
        
    }
}
