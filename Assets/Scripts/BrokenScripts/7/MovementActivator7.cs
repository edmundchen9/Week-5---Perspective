using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementActivator7 : MonoBehaviour
{
    [SerializeField] GameObject objectToActivate;
    [SerializeField] GameObject otherObjectToActivate;

    // Start is called before the first frame update
    void Start()
    {
    objectToActivate.GetComponent<MoveObject7>().enabled = false;
    //added other
    otherObjectToActivate.GetComponent<MoveObject7>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

//capitalize On for these methods
    private void OnTriggerEnter(Collider other)
    {
        objectToActivate.GetComponent<MoveObject7>().enabled = true;
        otherObjectToActivate.GetComponent<MoveObject7>().enabled = true;
    }
    //onTriggerExit spelt incorrectly
    private void OnTriggerExit(Collider other)
    {
        objectToActivate.GetComponent<MoveObject7>().enabled = false;
        otherObjectToActivate.GetComponent<MoveObject7>().enabled = false;
    }
}
