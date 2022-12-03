using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContrlAudio : MonoBehaviour
{
    public AudioSource source { get { return GetComponent<AudioSource>(); } }
    public Button btn { get { return GetComponent<Button>(); } }
    public AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<AudioSource>();
        btn.onClick.AddListener(PlaySound);

    }
    public void PlaySound()
    {
        source.PlayOneShot(clip);
    }

    // Update is called once per frame
    void Update()
    {

    }

}


