using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodBarToUI : MonoBehaviour
{
    [SerializeField] GameObject player;
    private Image foodBar;
    private const float MAX_FOOD = 100f;
    FoodBar foodAmount;
    
    
    void Start()
    {
        //get the components that we need for the food bar
        foodBar = GetComponent<Image>();
        foodAmount = player.GetComponent<FoodBar>();
        
    }

    
    void Update()
    {
        //make the bar = to the food ammount
        foodBar.fillAmount = foodAmount.food / MAX_FOOD; 
    }
}
