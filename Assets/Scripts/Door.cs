using UnityEngine;

public class Door : Sounds, Interactable
{
    public Animator animator;
    public bool isOpen;

    void Start()
    {
        if (isOpen)
        {
            animator.SetBool("isOpen", true);
        }
    }

    public string GetDescription()
    {
        if (isOpen) return "Нажмите [E] чтобы <color=red>закрыть</color> дверь";
        return "Нажмите [E] чтобы <color=green>открыть</color> дверь";
    }

    public void Interact()
    {
        isOpen = !isOpen;
        if (isOpen)
        {
            animator.SetBool("isOpen", true);
            PlaySound(sounds[0]);
        }
        else
        {
            animator.SetBool("isOpen", false);
            PlaySound(sounds[0]);
        }
    }
}
