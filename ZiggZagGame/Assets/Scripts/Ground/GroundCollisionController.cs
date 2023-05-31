using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCollisionController : MonoBehaviour
{
    [SerializeField] private GroundDataTransmittler groundDataTransmittler;





    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            groundDataTransmittler.SetGroundRigidbodyValues();
        }
    }
}
