using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] KeyCode _firstKey;
    [SerializeField] KeyCode _secondKey;
    [SerializeField] Vector3 _moveDirection;

    Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
         
        if (Input.GetKey(_firstKey))
        {
            Move(_moveDirection);
        }
        if (Input.GetKey(_secondKey))
        {
            Move(-_moveDirection);
        }
    }

    void Move(Vector3 moveDirection)
    {
        _rigidbody.velocity += moveDirection;
    }

    
}
