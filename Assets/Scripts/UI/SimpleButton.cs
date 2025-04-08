using UnityEngine;
using UnityEngine.UI;

public class SimpleButton : MonoBehaviour, IClickable
{
    public AudioSource clickSound;
    private Button button;

    /// <summary>
    /// Функция, вызывающаяся при клике
    /// </summary>
    public virtual void OnClick()
    {
        if (clickSound != null)
        {
            clickSound.Play();
            print("Проигрался");
        }
    }

    /// <summary>
    /// Добавление функции и звук на клик
    /// </summary>
    public void AddButtonListener()
    {
        clickSound = GameObject.FindGameObjectWithTag("ClickSound").GetComponent<AudioSource>();
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }
}
