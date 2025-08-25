using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class LightSwitch : MonoBehaviour, Interactable
{
    [SerializeField] private Animator animator;
    public Light m_Light;
    public bool isOn;

    void Start()
    {
        animator.SetBool("isOn", isOn);
        m_Light.enabled = isOn;
    }

    private const string ON_LIGHT_DESCRIPTION = "Нажмите [E] чтобы <color=red>включить</color> свет";
    private const string OFF_LIGHT_DESCRIPTION = "Нажмите [E] чтобы <color=green>выключить</color> свет";

    public string GetDescription()
    {
        return isOn ? ON_LIGHT_DESCRIPTION : OFF_LIGHT_DESCRIPTION;
    }

    public void Interact()
    {
        isOn = !isOn;
        animator.SetBool("isOn", isOn);
        m_Light.enabled = isOn;
        //PlaySound(sounds[0]);
    }
}
