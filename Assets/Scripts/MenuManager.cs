using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public void ExitGame()
    {
        Debug.Log("Exit pressed");
        Application.Quit();
    }
}
