using UnityEngine;

public class UI : MonoBehaviour
{

    public GameObject LeaderBoardPanel;

    public void ONGameLeadrePlanel()
    {
        LeaderBoardPanel.SetActive(true);
    }
    
    public void CloseLeaderBoardPlanel()
    {
        LeaderBoardPanel.SetActive(false);
    }
}
