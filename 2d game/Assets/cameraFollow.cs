using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform character;
    public Vector3 camDistance;
    [Range(1,10)]
    public float cameraSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
       camDistance[2] = -10f;
       cameraSpeed = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        followCharacter();
    }

    public void followCharacter()
    {
        if(character.position.y>-10)
            transform.position = Vector3.Lerp(transform.position,character.position+camDistance,cameraSpeed*Time.fixedDeltaTime);
    }
}
