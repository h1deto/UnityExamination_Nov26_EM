using TMPro;
using UnityEngine;

public class GameDataScript : MonoBehaviour
{
    
    [Header("Coins:")]
    [Tooltip("The amount of coins the player has.")]
    [SerializeField] public int playerCoins;
    
    [Tooltip("Drag text here to be used to draw coin amount on canvas.")]
    [SerializeField] public TextMeshProUGUI coinText;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerCoins = 0;
        coinText.text = ": " + playerCoins;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
