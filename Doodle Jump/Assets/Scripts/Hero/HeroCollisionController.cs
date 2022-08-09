using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroCollisionController : MonoBehaviour
{

    [SerializeField] private HeroDataTransmitter heroDataTransmitter;


    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.CompareTag("Platform"))
        {
            heroDataTransmitter.GetHeroJumpMovement();
        }
    }
}
