using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMovementController : MonoBehaviour
{
    [SerializeField] private HeroDataTransmitter heroDataTransmitter;
    [SerializeField] private Rigidbody2D heroRigidbody2D;
    [SerializeField] private float heroSpeedX;
    [SerializeField] private float heroJumpSpeed;


    void FixedUpdate()
    {
        SetHeroXMovement();
    }



    private void SetHeroXMovement()
    {
        heroRigidbody2D.velocity = new Vector2(heroDataTransmitter.GetHeroX() * heroSpeedX, heroRigidbody2D.velocity.y);
    }



    public void SetHeroJumpMovement()
    {
        heroRigidbody2D.AddForce(Vector2.up * heroJumpSpeed);
    }
}
