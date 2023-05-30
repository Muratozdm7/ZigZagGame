using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovementController : MonoBehaviour
{
    [SerializeField] private BallDataTransmittler BallDataTransmittler;

    [SerializeField] private float ballMoveSpeed;


    private void Update()
    {
        SetBallMovement();
    }

    private void SetBallMovement()
    {
        transform.position += BallDataTransmittler.GetBallDirection() * ballMoveSpeed * Time.deltaTime;
    }
}
