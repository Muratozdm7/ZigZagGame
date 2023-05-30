using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDataTransmittler : MonoBehaviour
{
    [SerializeField] private BallInputController BallInputController;


    public Vector3 GetBallDirection()
    {
        return BallInputController.ballDirection;
    }
}
