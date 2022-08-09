using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundLoopController : MonoBehaviour
{

    [SerializeField] private Transform cameraTransform;


    void Update()
    {

        if (cameraTransform.position.y >= transform.position.y + 10.56f)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + 10.56f);
        }
    }
}
