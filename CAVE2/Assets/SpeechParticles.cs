using UnityEngine;
using UnityEngine.UI;

public class TextParticleEmitter : MonoBehaviour
{
    public Text uiText;
    
    void Start()
    {
        uiText = GetComponent<Text>();
        uiText.enabled = false; // Initially hide the UI Text
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Adjust the condition as needed
        {
            EmitTextParticle();
        }
    }

    void EmitTextParticle()
    {
        uiText.enabled = true; // Show the UI Text
        uiText.text = "Your Text Here"; // Set the text on the UI Text

        // Implement a logic to hide the UI Text after a certain duration or condition.
    }
}