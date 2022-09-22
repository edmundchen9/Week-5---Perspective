using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementActivator6 : MonoBehaviour
{
    [SerializeField] GameObject objectToActivate;
    [SerializeField] GameObject otherObjectToActivate;

    // Start is called before the first frame update
    void Start()
    {
        //start had no preset on objectToActivate
    objectToActivate.GetComponent<MoveObject6>().enabled = false;
    otherObjectToActivate.GetComponent<MoveObject6>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        objectToActivate.GetComponent<MoveObject6>().enabled = true;
        otherObjectToActivate.GetComponent<MoveObject6>().enabled = true;
    }
    private void OnTriggerExit(Collider other)
    {
        objectToActivate.GetComponent<MoveObject6>().enabled = false;
        otherObjectToActivate.GetComponent<MoveObject6>().enabled = false;
    }
}
