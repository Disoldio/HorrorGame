using UnityEngine;

public class LightSwitch : MonoBehaviour, Interactable
{
    [SerializeField]
    private Animator animator;

    [SerializeField]
    private Light m_Light;

    [SerializeField]
    private bool isOn;

    private const string ON_LIGHT_DESCRIPTION = "Нажмите [E] чтобы <color=red>выключить</color> свет";
    private const string OFF_LIGHT_DESCRIPTION = "Нажмите [E] чтобы <color=green>включить</color> свет";

    void Start()
    {
        animator.SetBool("isOn", isOn);
        m_Light.enabled = isOn;
    }

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
