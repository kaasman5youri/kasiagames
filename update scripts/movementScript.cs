using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementScript : MonoBehaviour
{
    public float MovementSpeed = 1;
    public float SprintSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float MoveXWS = 0;
        float MoveXAD = 0;
        float MoveZWS = 0;
        float MoveZAD = 0;
        float CurrentSprintSpeed = 0;

        if (Input.GetKey(KeyCode.W))
        {
            MoveXWS = 1;
            MoveZWS = 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            MoveXWS = -1;
            MoveZWS = -1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            MoveXAD = -1;
            MoveZAD = 1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            MoveXAD = 1;
            MoveZAD = -1;
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            CurrentSprintSpeed = SprintSpeed;
        }
        Vector3 MoveDirection = new Vector3(MoveXWS + MoveXAD, 0, MoveZWS + MoveZAD).normalized;
        Vector3 TargetPosition = transform.position + MoveDirection * (MovementSpeed + CurrentSprintSpeed) * Time.deltaTime;

        if (!Physics.Raycast(transform.position, MoveDirection, (MovementSpeed + CurrentSprintSpeed) * Time.deltaTime + 5))
        {
            transform.position = TargetPosition;
        }
        else
        {

        }
    }
}
