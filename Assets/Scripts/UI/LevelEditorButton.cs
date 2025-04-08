using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEditorButton : SimpleButton
{
    /// <summary>
    /// Переписываем функцию добавлением функционал (переход на сцену LevelEditor)
    /// </summary>
    public override void OnClick()
    {
        base.OnClick();
        SceneManager.LoadScene("LevelEditor");
    }

    private void Start()
    {
        AddButtonListener();
    }
}
