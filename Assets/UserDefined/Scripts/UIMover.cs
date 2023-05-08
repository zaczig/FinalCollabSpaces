using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMover : MonoBehaviour
{
    [SerializeField] GameObject myCamera;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(myCamera.transform.position);
    }
}
