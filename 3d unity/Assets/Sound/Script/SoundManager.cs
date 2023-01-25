using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    // private �Ӽ��� ���ϰ� �ϸ鼭
    // �ν����� �ܺο� �����Ű�� ��Ʈ����Ʈ

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
