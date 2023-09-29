using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quick : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other);



        other.attachedRigidbody.AddForce(0, 30, -30 * 2, ForceMode.Impulse);

    }
}