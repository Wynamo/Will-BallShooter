using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdSpeed : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other);



        other.attachedRigidbody.AddForce(60, 0, 0 * 2, ForceMode.Impulse);

    }
}