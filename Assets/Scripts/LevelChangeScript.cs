using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class LevelChangeScript : MonoBehaviour
{
    private float timer;
    private bool activated = false;
    
    [Header("Level settings \n")]
    [Tooltip("Enter the exact name of the level you want to change to here.")]
    [SerializeField] private string nextLevelScene;
    
    [Header("Completion effects \n")]
    [Tooltip("Enable or disable the effects.")]
    [SerializeField] private bool effects = false;
    
    [Tooltip("For the effects to work, the effects checkbox must be pressed.")]
    [SerializeField] private AudioClip victorySound;
    
    [Tooltip("Drag mixer here if you want to lower other sounds.")]
    [SerializeField] private AudioMixer mixer;
    
    [Tooltip("Drag the player here to disable their movement while effects are being played.")]
    [SerializeField] private PlayerInput playerInput;

    
    
    public void ChangeLevel()
    {
        if (effects)
        {
            timer = victorySound.length;
            activated = true;
            mixer.SetFloat("MasterBGM", -80);
            AudioSource.PlayClipAtPoint(victorySound, transform.position);
            playerInput.enabled = false;
        }
        else
        {
            SceneManager.LoadScene(nextLevelScene);
        }
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (activated)
        {
            timer -= Time.deltaTime;
            if (timer < 0.1f) SceneManager.LoadScene(nextLevelScene);
        }
    }
}
