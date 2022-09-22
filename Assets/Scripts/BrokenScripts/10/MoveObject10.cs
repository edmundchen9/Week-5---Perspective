using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject10 : MonoBehaviour
{
    //serialize field
    [SerializeField] float moveSpeed;
    [SerializeField] Vector3 moveDirection;
    
    //add float
    float totalMoveDistance;
    Vector3 startingLocation;

    // Start is called before the first frame update
    void Start()
    {
       totalMoveDistance = 10f;
       startingLocation = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       float distanceTraveled = GetDistanceTraveled();

       if (distanceTraveled > totalMoveDistance)
       {
           FlipMoveDirection();
            //add enabled to false
           this.enabled = false;
       }

       gameObject.transform.Translate(moveDirection * moveSpeed);
    }

    void FlipMoveDirection()
    {
       moveDirection = -moveDirection;
       startingLocation = gameObject.transform.position;
    }

    float GetDistanceTraveled()
    {
       return Vector3.Distance(gameObject.transform.position, startingLocation);
    }
}
