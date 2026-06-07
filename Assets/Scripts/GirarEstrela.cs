using UnityEngine;

public class Estrela : MonoBehaviour
{
    private Animator animator;

    void Update()
    {
        if (gameObject.activeInHierarchy)
        {
            animator.SetBool("Ativa", true);
        }
    }
        private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}