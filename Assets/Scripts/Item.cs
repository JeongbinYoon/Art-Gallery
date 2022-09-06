using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
   public float rotateSpeed;
   GameObject child = null;

    void Start(){
        child = transform.GetChild(0).gameObject;
    }

    void Update()
    {
        // transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime, Space.World);
    }

    private void OnTriggerStay(Collider other)
    {
        child.transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime, Space.World);
    }
}
