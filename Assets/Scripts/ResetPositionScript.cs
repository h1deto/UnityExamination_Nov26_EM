using UnityEngine;

public class ResetPositionScript : MonoBehaviour
{
    
    [Header("Character")]
    [Tooltip("Drag the character that you want to use here.")]
    [SerializeField] private Transform charTransform;
    
    [Header("Positions: \n")]
    [Tooltip("Set the X position to reset to.")]
    [SerializeField] private float xPosition;
    [Tooltip("Set the Y position to reset to.")]
    [SerializeField] private float yPosition;
    [Tooltip("Set the Z position to reset to, this is useful for layers.")]
    [SerializeField] private float zPosition;

    
    [Header("Sound effect: \n")]
    [Tooltip("Enable this to play a sound on position change.")]
    [SerializeField] private bool enableSoundEffect = false;
    
    [Tooltip("Drag sound effect here.")]
    [SerializeField] private AudioClip audioClip;
    
    
    public void OnLeavingArea()
    {
        charTransform.position = new Vector3(xPosition, yPosition, zPosition);
        if (enableSoundEffect) AudioSource.PlayClipAtPoint(audioClip, new Vector3(xPosition, yPosition, zPosition));
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
