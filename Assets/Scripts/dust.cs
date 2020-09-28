using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dust : MonoBehaviour, IPooledObject
{
    public void OnObjectSpawn()
    {
        ParticleSystem obj = GetComponent<ParticleSystem>();
        
        obj.Play();
    }
}
