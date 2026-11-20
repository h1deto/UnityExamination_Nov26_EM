using UnityEngine;

public class SnowmanScript : MonoBehaviour
{
    
    public bool snowmanPickup = false;
    
    [SerializeField] private Transform playerTransform;
    private Transform snowmanTransform;

    public void PickUpSnowman()
    {
        snowmanPickup = true;
        
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        snowmanTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (snowmanPickup)
        {
            snowmanTransform.position = playerTransform.position;
        }
    }
}
