using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue : MonoBehaviour
{
    public string name; // Changed 'name' to 'speakerName' to avoid hiding the inherited member

    [TextArea(3, 10)]
    public string[] sentences;

    public AudioClip[] audioClips; // Added audioClips array for storing audio clips
}