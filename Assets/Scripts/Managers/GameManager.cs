using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    private int _playerIndex = -1; // �÷��̾� �ε����� ������ ����

    // GameManager�� ������ �ν��Ͻ��� �����ϴ� ������Ƽ
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<GameManager>();
                if (_instance == null)
                {
                    GameObject manager = new GameObject("GameManager");
                    _instance = manager.AddComponent<GameManager>();
                }
            }
            return _instance;
        }
    }

    private void Awake()
    {
        // �ν��Ͻ��� �̹� ���� ��� ���� GameManager ��ũ��Ʈ�� �ı�
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

    public void GameStart()
    {
        SceneManager.LoadScene("MainScene");
    }

    // �÷��̾� �ε��� ���� �޼���
    public void SetPlayerIndex(int index)
    {
        _playerIndex = index;
    }

    // �÷��̾� �ε����� �������� �޼���
    public int GetPlayerIndex()
    {
        return _playerIndex;
    }

}
