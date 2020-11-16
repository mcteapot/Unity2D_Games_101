using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController2DMovement : MonoBehaviour
{

    public CharacterController2D characterController;

    public float runSpeed = 40.0f;
    private float horizontalMove = 0f;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        bool jump = false;
        bool crouch = false;

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        Debug.Log("Horizontal Speed: " + horizontalMove);


        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            jump = true;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow)) 
        {
            crouch = true;
        }



        characterController.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
    }
}
