using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skins : MonoBehaviour
{
    public GameObject Nemec;
    public GameObject t54;
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            Nemec.SetActive(true);
            t54.SetActive(false);
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            Nemec.SetActive(false);
            t54.SetActive(true);
        }
    }
}
