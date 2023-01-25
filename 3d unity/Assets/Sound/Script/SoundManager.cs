using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    // private 속성을 지니게 하면서
    // 인스펙터 외부에 노출시키는 어트리뷰트

    [SerializeField] AudioClip[] audioClip;
    [SerializeField] AudioSource soundSource;
    [SerializeField] AudioSource effectSource;
    public void SoundCall(int count)
    {
        effectSource.PlayOneShot(audioClip[count]);
    }

    public void Volume(float volume)
    {
        soundSource.volume = volume;
    }



    void Update()
    {
        
    }
}
