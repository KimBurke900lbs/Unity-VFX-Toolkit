using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class ParentParticleEffect : MonoBehaviour
{
    public Transform spawnPos;
    public VisualEffect particleEffect;

    // Update is called once per frame
    void Update()
    {
        particleEffect.SetVector3("SpawnPos", spawnPos.position);
    }
}
