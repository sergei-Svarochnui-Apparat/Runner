using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float speed;
    private float OldMousePosition;
    private float eulerY;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            OldMousePosition = Input.mousePosition.x;
        }
        if (Input.GetMouseButton(0))
        {
        Vector3 newPosition = transform.position + transform.forward * Time.deltaTime * speed;
        newPosition.x = Mathf.Clamp(newPosition.x, -5.5f, 5.5f);
            transform.position = newPosition;
        float deltaX = Input.mousePosition.x - OldMousePosition;
        OldMousePosition = Input.mousePosition.x;

        eulerY += deltaX;
        eulerY = Mathf.Clamp(eulerY ,-70,70);
        transform.eulerAngles = new Vector3(0, eulerY, 0);
        }
    }
}
