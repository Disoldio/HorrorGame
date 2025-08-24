using UnityEngine;

public class Door : Sounds, Interactable
{
    [SerializeField]
    private Animator animator;

    [SerializeField]
    private bool isOpen;

    private const string OPEN_DOOR_DESCRIPTION = "Нажмите [E] чтобы <color=red>закрыть</color> дверь";
    private const string CLOSED_DOOR_DESCRIPTION = "Нажмите [E] чтобы <color=green>открыть</color> дверь";
    void Start()
    {
        animator.SetBool("isOpen", isOpen);
    }

    public string GetDescription()
    {
        return isOpen ? OPEN_DOOR_DESCRIPTION : CLOSED_DOOR_DESCRIPTION;
    }

    public void Interact()
    {
        isOpen = !isOpen;
        animator.SetBool("isOpen", isOpen);
        PlaySound(sounds[0]);
    }
}
