using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSX : MonoBehaviour
{
    [Header("--------Audio Source ------------")]
    [SerializeField] AudioSource audioSource;
    [Header("--------Audio Clip ------------")]
    public AudioClip hang0;
    public AudioClip hang1;
    public AudioClip hang2;
    public AudioClip hang3;
    public AudioClip hang4;
    public AudioClip hang5;
    public AudioClip hang6;
    public AudioClip hang7;
    public AudioClip hang8;
    public AudioClip hang9;
    public AudioClip hang10;
    public AudioClip hang11;
    public AudioClip hang12;
    public AudioClip hang13;
    public AudioClip hang14;
    public AudioClip[] hangok= new AudioClip[15];
    void Start()
    {
        hangok[0] = hang0;
        hangok[1] = hang1;
        hangok[2] = hang2;
        hangok[3] = hang3;
        hangok[4] = hang4;
        hangok[5] = hang5;
        hangok[6] = hang6;
        hangok[7] = hang7;
        hangok[8] = hang8;
        hangok[9] = hang9;
        hangok[10] = hang10;
        hangok[11] = hang11;
        hangok[12] = hang12;
        hangok[13] = hang13;
        hangok[14] = hang14;
    }
    public void playAudio(AudioClip h)
    {
        audioSource.PlayOneShot(h);
    }
}
