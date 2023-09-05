using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footstep : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip grass;
    public AudioClip wood;
    public AudioClip concrete;

    public Transform rayStart;
    public float range;
    public LayerMask layerMask;

    public void FootStep()
    {
        if (Physics.Raycast(rayStart.position, rayStart.transform.up * -1, out RaycastHit hit, range, layerMask))
        {
            if (hit.collider.CompareTag("Grass"))
            {
                PlayFootstepSoundL(grass);
            }
            if (hit.collider.CompareTag("Wood"))
            {
                PlayFootstepSoundL(wood);
            }
            if (hit.collider.CompareTag("Concrete"))
            {
                PlayFootstepSoundL(concrete);
            }
        }
    }
    void PlayFootstepSoundL(AudioClip audio)
    {
        audioSource.pitch = Random.Range(0.8f, 1f);
        audioSource.PlayOneShot(audio);
    }
    private void Update()
    {
        Debug.DrawRay(rayStart.position, rayStart.transform.up * range * -1, Color.green);
    }
}
