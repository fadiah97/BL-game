using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI; //for using the ui elemnts 
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{



    public float MaxHealth; //character full health
    float currentHealth; //current health
    public GameObject DeathAffect; //the death affect 

    public Slider HealthSlider;// the ui element that will show the health state 
    public GameObject GameoverUI;
      



    private void Start()
    {
        currentHealth = MaxHealth; // at first the current health equal the max health 
        GameoverUI.SetActive(false);
         HealthSlider.maxValue = MaxHealth; //the full health of the slider will equal the max health of the player 
         HealthSlider.value = MaxHealth;//current health equal the max health 
    }

 

    public void AddDamege(float damege)
    {


        if (damege <= 0) return;
             

        currentHealth -= damege; // decrease the health by the amount of the damege 
        HealthSlider.value = currentHealth;// change the value of the slider 




        if (currentHealth <= 0) // if ran out of health die 
        {
             
            MakeDead();
        }
    }

    public void MakeDead()
    {
        Destroy(gameObject); // destroy the object 
        GameoverUI.SetActive(true);
        Instantiate(DeathAffect, transform.position, transform.rotation); // instantiat the affect at this  position
    }


   
}
