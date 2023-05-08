using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    private Vector3 initialPosition;
    private Quaternion initialRotation;
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        initialRotation = new Quaternion(transform.rotation.x, transform.rotation.y, transform.rotation.z, transform.rotation.w);
    }

    // Update is called once per frame
    public void Reset()
    {
        transform.SetPositionAndRotation(initialPosition, initialRotation);
    }
}
