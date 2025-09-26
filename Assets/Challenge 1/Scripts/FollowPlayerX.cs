using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    Vector3 offset = new Vector3(20, 0, 0);

    
    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}
