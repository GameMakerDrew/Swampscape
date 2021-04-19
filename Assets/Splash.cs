using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splash : MonoBehaviour
{

    public ParticleSystem splash;
    public AudioSource splashIn;
    public AudioSource splashOut;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
  
        Vector3 splashPos = new Vector3(other.transform.position.x, 0f, other.transform.position.z);
        splashOut.Stop();
        splashIn.Play();
        Instantiate(splash, splashPos, other.transform.rotation);
       // splash.Play();
        Debug.Log("Hit: " + other.transform.tag);
    }

    private void OnTriggerExit(Collider other)
    {
        Vector3 splashPos = new Vector3(other.transform.position.x, 0f, other.transform.position.z);
        splashIn.Stop();
        splashOut.Play();
        Instantiate(splash, splashPos, other.transform.rotation);
    }
}
