using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class LightTimmy : MonoBehaviour
{
    [SerializeField] GameObject player;
   
    Light lighting;
    FoodBar foodAmount;

    void Start()
    {
        lighting = GetComponent<Light>();
        foodAmount = player.GetComponent<FoodBar>();
    }

    // Update is called once per frame
    void Update()
    {
        lighting.spotAngle = foodAmount.food + 50;

    }
    
}
