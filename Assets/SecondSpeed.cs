using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondSpeed : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other);



        other.attachedRigidbody.AddForce(-75, 0, 0 * 2, ForceMode.Impulse);

    }
}