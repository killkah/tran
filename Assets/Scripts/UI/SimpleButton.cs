using UnityEngine;
using UnityEngine.UI;

public class SimpleButton : MonoBehaviour, IClickable
{
    public AudioSource clickSound;
    private Button button;

    /// <summary>
    /// �������, ������������ ��� �����
    /// </summary>
    public virtual void OnClick()
    {
        if (clickSound != null)
        {
            clickSound.Play();
            print("����������");
        }
    }

    /// <summary>
    /// ���������� ������� � ���� �� ����
    /// </summary>
    public void AddButtonListener()
    {
        clickSound = GameObject.FindGameObjectWithTag("ClickSound").GetComponent<AudioSource>();
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }
}
