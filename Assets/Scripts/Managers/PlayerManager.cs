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
        Debug.Log("�÷��̾� �̸��� ���ο��� �����Ǿ����ϴ�.");
    }

    public string GetPlayerName()
    {
        return _playerName;
    }

    // GameManager�� �÷��̾� �ε����� �����ͼ� player1 �� player2 ������Ʈ�� Ȱ��ȭ �Ǵ� ��Ȱ��ȭ
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
