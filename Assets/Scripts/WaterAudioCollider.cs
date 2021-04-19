using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterAudioCollider : MonoBehaviour
{

    public AudioSource splashIn;
    public AudioSource splashOut;
    public ParticleSystem splashParticleIn;
    public ParticleSystem splashParticleOut;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    //private void OnTriggerEnter(Collider other)
    //{
    //    Debug.Log("Collision");

    //    if (other.transform.tag == "Water")
    //    {
    //        splashIn.Play();
    //        Vector3 splashPos = new Vector3(transform.position.x, transform.position.y - 0.1f, transform.position.z);
    //        var clone = Instantiate(splashParticleIn, splashPos, Quaternion.Euler(new Vector3(0f, 0f, 0f))) as ParticleSystem;
    //    }
    //}

    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.transform.tag == "Water")
    //    {
    //        splashOut.Play();
    //        Vector3 splashPos = new Vector3(transform.position.x, transform.position.y - 0.2f, transform.position.z);
    //        var clone = Instantiate(splashParticleOut, splashPos, Quaternion.Euler(new Vector3(0f, 0f, 0f)))as ParticleSystem;
    //    }
    //}
}
