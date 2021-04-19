using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowFishMovement : MonoBehaviour
{
    public float dangerRange;
    public float speed = 1f;
    private GameObject follow;
    public Transform sphere;
    public Animator animator;

    private bool moving = true;



    // Start is called before the first frame update
    void Start()
    {
        follow = GameObject.Find("FirstPersonPlayer");


    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(sphere.position.y);
        MoveEnemy();
    }

    void MoveEnemy()
    {
        if (Vector3.Distance(transform.position, follow.transform.position) < dangerRange)
        {
            Vector3 targetDirection = follow.transform.position - transform.position;

            float singleStep = speed * Time.deltaTime;

            Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, singleStep, 0.0f);

            Debug.DrawRay(transform.position, newDirection, Color.red);

            transform.rotation = Quaternion.LookRotation(newDirection);

            Vector3 current = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            Vector3 followCoord = new Vector3(follow.transform.position.x, transform.position.y, follow.transform.position.z);
            transform.position = Vector3.MoveTowards(current, followCoord, 0.13f);
            animator.SetBool("isMoving", true);

        }
        else
        {
            animator.SetBool("isMoving", false);
        }
    }

}

