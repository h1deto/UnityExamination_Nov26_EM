using UnityEngine;

public class FlagDoorScript : MonoBehaviour
{
    [Header("Door settings: \n")]
    [Tooltip("Select the door in the scene you want this flag to affect.")]
    [SerializeField] private SpriteRenderer doorTop;
    [SerializeField] private SpriteRenderer doorBottom;
    
    [Tooltip("Select the sound you want the door to make.")]
    [SerializeField] private AudioClip doorSound;
    
    [Tooltip("Select the collider you want to activate.")]
    [SerializeField] private BoxCollider2D nextLevelCollider;
    
    private CircleCollider2D circleCollider;
    
    public void OnFlagCollision()
    {
        AudioSource.PlayClipAtPoint(doorSound, transform.position);
        doorTop.color = Color.black;
        doorBottom.color = Color.black;
        circleCollider.enabled = false;
        nextLevelCollider.enabled = true;
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        circleCollider = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
