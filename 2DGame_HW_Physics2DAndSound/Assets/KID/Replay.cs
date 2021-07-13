using UnityEngine;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour
{
    /// <summary>
    /// �����W��
    /// </summary>
    private string nameScene;

    /// <summary>
    /// ���s�}�l�C��
    /// </summary>
    /// <param name="scene">�n���s�}�l������</param>
    public void ReplayGame(string scene)
    {
        nameScene = scene;
        Invoke("DelayReplay", 1.5f);
    }

    /// <summary>
    /// ���𭫷s�C��
    /// </summary>
    private void DelayReplay()
    {
        SceneManager.LoadScene(nameScene);
    }
}
