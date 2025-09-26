using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProfellerSpin : MonoBehaviour
{
    [SerializeField] float spinSpeed;
    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * spinSpeed);
    }
}
