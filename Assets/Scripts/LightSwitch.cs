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

    private const string ON_LIGHT_DESCRIPTION = "������� [E] ����� <color=red>��������</color> ����";
    private const string OFF_LIGHT_DESCRIPTION = "������� [E] ����� <color=green>���������</color> ����";

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
