using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] Vector3 offset = new Vector3(0, 5, -12);

    // 카메라 이동은 LateUpdate에서 실행할 수 있도록
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
