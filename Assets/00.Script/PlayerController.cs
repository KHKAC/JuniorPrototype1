using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float horsePower = 20.0f;
    [SerializeField] float turnSpeed;
    [SerializeField] GameObject centerOfMass;
    [SerializeField] TextMeshProUGUI speedMeterText;
    [SerializeField] float speed;
    [SerializeField] TextMeshProUGUI rpmText;
    [SerializeField] float rpm;

    [SerializeField] List<WheelCollider> allWheels;
    [SerializeField] int wheelsOnGround;

    float horizontalInput;
    float verticalInput;
    Rigidbody playerRb;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerRb.centerOfMass = centerOfMass.transform.position;
    }

    void FixedUpdate()
    {
        //Input Manager를 활용한 키 입력
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //if (IsOnGround())
        {
            speed = Mathf.Round(playerRb.velocity.magnitude * 2.237f);
            speedMeterText.SetText($"SPEED : {speed}mph");
            rpm = Mathf.Round((speed % 30) * 40);
            rpmText.SetText($"RPM : {rpm}");
            // 차량 전후 진행
            // transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput); //Translate(0, 0, 1);
            playerRb.AddRelativeForce(Vector3.forward * verticalInput * horsePower);
            // 차량 좌우 회전
            transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
        }

    }

    bool IsOnGround()
    {
        wheelsOnGround = 0;
        foreach (WheelCollider wheel in allWheels)
        {
            if (wheel.isGrounded)
            {
                wheelsOnGround++;
            }
        }
        return wheelsOnGround == 4 ? true : false;
    }
}
