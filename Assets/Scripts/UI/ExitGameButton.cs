using UnityEngine;

public class ExitGameButton : SimpleButton
{
    public override void OnClick()
    {
        base.OnClick();
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPaused = true;
        #else
            Application.Quit();
        #endif
    }

    private void Start()
    {
        AddButtonListener();
    }
}
