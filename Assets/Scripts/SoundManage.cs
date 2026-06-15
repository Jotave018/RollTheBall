using UnityEngine;

public class SoundManage : MonoBehaviour
{
public AudioSource Sounds;
public AudioClip popSound;

public void OntriggerSound()
    {
        Sounds.PlayOneShot(popSound);
    }
}
