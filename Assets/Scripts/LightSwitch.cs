using UnityEngine;

public class LightSwitch : MonoBehaviour, Interactable
{
    [SerializeField]
    private Animator animator;

    [SerializeField]
    private Light m_Light;

    [SerializeField]
    private bool isOn;

    private const string ON_LIGHT_DESCRIPTION = "������� [E] ����� <color=red>���������</color> ����";
    private const string OFF_LIGHT_DESCRIPTION = "������� [E] ����� <color=green>��������</color> ����";

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
