using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustFoot : MonoBehaviour
{
    public Transform john;
    ObjectPooler objectPooler;
    private void Start() {
        objectPooler = ObjectPooler.Instance;
    }
    
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis ("Horizontal");
        float vertical = Input.GetAxis ("Vertical");
        bool hasHorizontalInput = !Mathf.Approximately(horizontal, 0f);
        bool hasVerticalInput = !Mathf.Approximately(vertical, 0f);
        bool isWalking = hasHorizontalInput || hasVerticalInput;
        if(isWalking)
        {
            objectPooler.SpawnFromPool("DustFoot", john.position, john.rotation);
        }
        
    }
}
