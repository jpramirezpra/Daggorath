using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GVR;

public class audioManager : MonoBehaviour {

    public AudioClip myClipSelect;
    public AudioClip myClipPaint;
    public GvrAudioSource mySourceSelect;
    public GvrAudioSource mySourcePaint;

    // Use this for initialization
    void Start()
    {
        mySourceSelect.clip = myClipSelect;
        mySourcePaint.clip = myClipPaint;
        mySourceSelect.playOnAwake = false;
        mySourcePaint.playOnAwake = false;

    }

    private void Update()
    {
        mySourceSelect.Play();
    }
}
