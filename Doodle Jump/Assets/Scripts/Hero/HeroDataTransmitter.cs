using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroDataTransmitter : MonoBehaviour
{

    [SerializeField] private HeroInputController heroInputController;
    [SerializeField] private HeroMovementController heroMovementController;



    public float GetHeroX()
    {
        return heroInputController.heroX;
    }



    public void GetHeroJumpMovement()
    {
        heroMovementController.SetHeroJumpMovement();
    }
}
