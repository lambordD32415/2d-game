using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControls : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 40f;
    float horizontalMove = 0f;
    // Update is called once per frame
    void Update()
    {
       horizontalMove = Input.GetAxisRaw("Horizontal") * speed;
    }

    void FixedUpdate ()
    {
       // CharacterController.Move(horizontalMove * Time.fixedDeltaTime, false, false);
    }
}
