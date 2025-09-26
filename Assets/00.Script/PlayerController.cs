using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 20.0f;
    [SerializeField] float turnSpeed;
    float horizontalInput;
    float forwardInput;

    void Update()
    {
        //Input Manager를 활용한 키 입력
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // 차량 전후 진행
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput); //Translate(0, 0, 1);
        // 차량 좌우 회전
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
