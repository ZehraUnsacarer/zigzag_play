using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallInputController : MonoBehaviour
{

    public Vector3 ballDirection;


    void Start()
    {
        ballDirection = Vector3.left;
    }

    void Update()
    {
        HandleBallInput();
    }

    private void HandleBallInput()
    {
        if (Input.GetMouseButtonDown(0))//0 farenin sol kli�ini temsil ediyor, telefonda ekrana dokunarakta oynanmas�n� sa�l�yor
        {
            ChangeBallDirection();
        }
    }

    private void ChangeBallDirection()
    {
        if (ballDirection.x == -1)
        {
            ballDirection = Vector3.forward;//forward z y�n�ndeki ileri y�n� temsil ediyor
        }
        else
        {
            ballDirection = Vector3.left;
        }
    }
}
