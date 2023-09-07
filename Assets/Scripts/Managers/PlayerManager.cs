using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private string _playerName;

    private static PlayerManager _instance;

    public static PlayerManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<PlayerManager>();
                if (_instance == null)
                {
                    GameObject manager = new GameObject("PlayerManager");
                    _instance = manager.AddComponent<PlayerManager>();
                }
            }
            return _instance;
        }
    }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    public void SetPlayerName(string name)
    {
        _playerName = name;
        Debug.Log("플레이어 이름이 메인에서 설정되었습니다.");
    }

    public string GetPlayerName()
    {
        return _playerName;
    }

    // GameManager의 플레이어 인덱스를 가져와서 player1 및 player2 오브젝트를 활성화 또는 비활성화
    public void UpdatePlayerObjects()
    {
        int playerIndex = GameManager.Instance.GetPlayerIndex();
        GameObject player1 = GameObject.Find("Player");
        GameObject player2 = GameObject.Find("Player2"); 

        if (player1 != null && player2 != null)
        {
            if (playerIndex == 0)
            {
                player1.SetActive(true);
                player2.SetActive(false);
            }
            else if (playerIndex == 1)
            {
                player1.SetActive(false);
                player2.SetActive(true);
            }
        }
    }
}
