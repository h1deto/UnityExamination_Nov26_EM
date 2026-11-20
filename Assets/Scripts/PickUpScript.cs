using TMPro;
using UnityEngine;

public class PickUpScript : MonoBehaviour
{
    [Tooltip("Drag the sound you want to be played on pickup here.")]
    [SerializeField] AudioClip pickUpSound;
    
    private GameDataScript gameData;

    public void OnPickUp()
    {
        AudioSource.PlayClipAtPoint(pickUpSound, transform.position);
        gameData.playerCoins += 1;
        gameData.coinText.text = ": " + gameData.playerCoins;
        gameObject.SetActive(false);
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameData = FindAnyObjectByType<GameDataScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
