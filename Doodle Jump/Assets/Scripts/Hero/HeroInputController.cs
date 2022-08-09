using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroInputController : MonoBehaviour
{

    public float heroX;


    void Update()
    {
        SetHeroX();
    }



    private void SetHeroX()
    {
        heroX = Input.GetAxis("Horizontal");
    }
}
