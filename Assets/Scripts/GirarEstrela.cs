using UnityEngine;

public class Estrela : MonoBehaviour
{
    private Animator animator;
    public AudioSource Sounds;
    public AudioClip popSound;

    void Update()
    {
        if (gameObject.activeInHierarchy)
        {
            //animator.SetBool("Ativa", true);
        }
    }
    public void OnTriggerEnter()
    {
        Sounds.PlayOneShot(popSound);
        //Debug.Log("Tocoum um PopSound");
    }
}