using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller_1 : MonoBehaviour{

    public Animator animator;
    public float speed=2.0f;

    void Update(){
        
        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
        animator.SetFloat("Vertical", Input.GetAxis("Vertical"));

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);
        transform.position = transform.position + move * Time.deltaTime * speed;

    }
}