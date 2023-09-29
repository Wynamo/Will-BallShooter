using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other);



        other.attachedRigidbody.AddForce(0, 0, -45 * 2, ForceMode.Impulse);

    }
}