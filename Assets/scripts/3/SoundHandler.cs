using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundHandler : MonoBehaviour
{
    public AudioSource aus;
    [Range(0f,1f)]
    public float volcap;
    public float scale;
    // Start is called before the first frame update
    void Start()
    {
        if (aus == null) aus = GetComponent<AudioSource>();
        if (volcap < 1f) volcap = 1f;
        aus.volume = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!(aus.volume == volcap)) aus.volume += scale * Time.deltaTime;
        else if (aus.volume < 1f) aus.volume = 1f;
    }
}
