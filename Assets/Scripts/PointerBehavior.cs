using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerBehavior : MonoBehaviour
{

    private Game game;
    float range = 8f;
    public ParticleSystem explosion;
    public AudioSource pop;

    public Animator spearAnim;
    public Animator fishAnim;
   

    public Camera fpsCam;

    private void Start()
    {
        game = GameObject.FindObjectOfType<Game>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            SpearHit();
        }
            
    }
    //TODO: Pointer looks at ground check maybe
    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            if (hit.transform.tag == "Enemy")
            {
                Instantiate(explosion, hit.transform.position, hit.transform.rotation);
                pop.Play();
                game.updateScore();
                Destroy(hit.transform.parent.gameObject, 0f);
            }
        }
    }

    void SpearHit()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            if (hit.transform.tag == "Enemy")
            {
                
                fishAnim.SetBool("gotHit", true);
                spearAnim.SetBool("isSwinging", true);

            }
        }
    }
}
