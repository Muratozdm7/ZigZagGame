using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDataTransmittler : MonoBehaviour
{
    [SerializeField] private GroundFallController groundFallController;



    public void SetGroundRigidbodyValues()
    {
        StartCoroutine(groundFallController.SetRigidbodyValue());
    }
}
