using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem dustParticles;
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Track")
        {
            dustParticles.Play();
        }
    }
    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Track")
        {
            dustParticles.Stop();
        }
    }
}
