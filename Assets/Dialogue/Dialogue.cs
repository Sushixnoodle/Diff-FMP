using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue : MonoBehaviour
{
    public string name1; // Changed 'name' to 'name1' to avoid hiding the inherited member
    public string name2; // Added 'name2' for the second speaker

    [TextArea(3, 10)]
    public string[] sentences;

    public AudioClip[] audioClips; // Added audioClips array for storing audio clips
}