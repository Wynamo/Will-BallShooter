using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other);



        other.attachedRigidbody.AddForce(0, 25, -15 * 5, ForceMode.Impulse);

    }
}