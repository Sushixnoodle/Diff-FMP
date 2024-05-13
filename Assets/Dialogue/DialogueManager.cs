using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI nameText2; // Add another TextMeshProUGUI field
    public TextMeshProUGUI dialogueText;

    public Animator animator;

    public Queue<string> sentences;
    public Queue<AudioClip> audioClips; // Queue for audio clips

    public AudioSource audioSource; // Reference to the AudioSource component

    private AudioClip currentAudioClip; // Track the currently playing audio clip
    private bool isNameText1Active = true; // Track which name text is currently active

    void Awake()
    {
        sentences = new Queue<string>();
        audioClips = new Queue<AudioClip>(); // Initialize the audio clip queue
    }

    public void StartDialogue(Dialogue dialogue)
    {
        animator.SetBool("IsOpen", true);

        // Initially, show nameText and hide nameText2
        nameText.gameObject.SetActive(isNameText1Active);
        nameText2.gameObject.SetActive(!isNameText1Active);

        sentences.Clear();
        audioClips.Clear(); // Clear the audio clip queue

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        foreach (AudioClip clip in dialogue.audioClips)
        {
            audioClips.Enqueue(clip);
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

        if (audioClips.Count > 0)
        {
            currentAudioClip = audioClips.Dequeue();
            audioSource.PlayOneShot(currentAudioClip);
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

    public void ToggleNameText()
    {
        isNameText1Active = !isNameText1Active;
        nameText.gameObject.SetActive(isNameText1Active);
        nameText2.gameObject.SetActive(!isNameText1Active);
    }
}