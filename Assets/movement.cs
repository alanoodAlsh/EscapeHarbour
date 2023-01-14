using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private CharacterController charactercontroller;
    public float Speed;
    public Animator anim;
    float Verticalmovement;
    float Horizontalmovement;
    // Start is called before the first frame update
    void Start()
    {
        anim=GetComponent<Animator>();
        charactercontroller=GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
     
        anim.SetFloat("walkingHorizontal", Input.GetAxis("Horizontal"));
        anim.SetFloat("WalkingVertical", Input.GetAxis("Vertical"));
        Speed = 3;
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        movement.Normalize();
        charactercontroller.Move(movement*Speed*Time.deltaTime);
        if (movement != Vector3.zero)
            transform.forward = movement;
    }
}
