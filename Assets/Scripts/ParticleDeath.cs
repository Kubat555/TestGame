using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleDeath : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyParticle", 1f);
    }

    private void DestroyParticle()
    {
        Destroy(gameObject);
    }
}
