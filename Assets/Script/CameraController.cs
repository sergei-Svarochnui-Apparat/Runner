using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform Target;

    // Update is called once per frame
    void LaterUpdate()
    {
        transform.position = Target.position;
    }
}
