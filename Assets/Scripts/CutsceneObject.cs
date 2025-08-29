using UnityEngine;
using UnityEngine.Playables;

public class CutsceneObject : MonoBehaviour, Interactable
{
    [SerializeField]
    private PlayableDirector cutscene;
    public string GetDescription()
    {
        return null;
    }

    public void Interact()
    {
        cutscene.Play();
    }
}
