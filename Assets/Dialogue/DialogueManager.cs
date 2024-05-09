using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;

    public Animator animator;

    public Queue<string> sentences;
    public Queue<AudioClip> audioClips; // Queue for audio clips

    public AudioSource audioSource; // Reference to the AudioSource component

    private AudioClip currentAudioClip; // Track the currently playing audio clip

    void Awake()
    {
        sentences = new Queue<string>();
        audioClips = new Queue<AudioClip>(); // Initialize the audio clip queue
    }

    public void StartDialogue(Dialogue dialogue)
    {
        animator.SetBool("IsOpen", true);

        nameText.text = dialogue.name;

        sentences.Clear();
        audioClips.Clear(); // Clear the audio clip queue

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        foreach (AudioClip clip in dialogue.audioClips) // Assuming each sentence corresponds to an audio clip
        {
            audioClips.Enqueue(clip); // Enqueue the audio clips
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        // Stop the currently playing audio clip
        if (currentAudioClip != null && audioSource.isPlaying)
        {
            audioSource.Stop();
        }

        string sentence = sentences.Dequeue();
        StartCoroutine(TypeSentence(sentence));


        if (audioClips.Count > 0) // Check if there are any audio clips left
        {
            currentAudioClip = audioClips.Dequeue(); // Dequeue the next audio clip
            audioSource.PlayOneShot(currentAudioClip); // Play the audio clip
        }
    }


    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
    }
}