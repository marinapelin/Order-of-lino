using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("-------Audio Source-------")]
    [SerializeField] AudioSource musicSourse;
    [SerializeField] AudioSource SFXSourse;

    [Header("-------Audio Clip-------")]
    public AudioClip background;
    public AudioClip openDoor;
    public AudioClip closeDoor;
    public AudioClip openBox;
    public AudioClip getMagicItem;

    private void Start()
    {
        musicSourse.clip = background;
        musicSourse.volume = 0.2f;
        musicSourse.Play();
        SFXSourse.volume = 0.2f;
        SFXSourse.clip = getMagicItem;
    }
}
