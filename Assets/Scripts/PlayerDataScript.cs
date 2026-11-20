using TMPro;
using UnityEngine;

public class PlayerDataScript : MonoBehaviour
{
    
    [Header("Health:")]
    [Tooltip("The amount of health the player has.")]
    [SerializeField] private int startingHealth = 3;
    [SerializeField] private int currentHealth;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = startingHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
