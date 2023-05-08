using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapToLocation : MonoBehaviour
{

    private bool grabbed;
    private bool insideSnapZone;
    //public bool hasObject; // Shows whether the snap point holds any object or not
    //public bool isGround; // If it is true the snap point will be always active
    private GameObject collidingObject;

    //[SerializeField] SnapToLocation belowSnapPoint;
    //[SerializeField] SnapToLocation aboveSnapPoint;

    // Start is called before the first frame update
    void Start()
    {
        InitializeStates();
    }

    private void InitializeStates()
    {
        grabbed = false;
        insideSnapZone = false;
        //hasObject = false;
        collidingObject = null;
    }

    private void OnTriggerEnter(Collider other)
    {
        insideSnapZone = true;
        collidingObject = other.gameObject;
    }

    private void OnTriggerExit(Collider other)
    {
        insideSnapZone = false;
        other.GetComponent<Rigidbody>().isKinematic = false;
        //hasObject = false;
        
    }

    void SnapObject()
    {
        if (!grabbed && insideSnapZone)
        {
            collidingObject.transform.SetPositionAndRotation(transform.position, transform.rotation);
            collidingObject.GetComponent<Rigidbody>().isKinematic = true;
            //hasObject = true;
        }
    }



    // Update is called once per frame
    void Update()
    {
        if (collidingObject == null) return;
        grabbed = collidingObject.GetComponent<XRGrabNetworkInteractable>().isSelected;
        //if (isGround || belowSnapPoint.hasObject)
        //{
            SnapObject();
        //}
        
    }
}
