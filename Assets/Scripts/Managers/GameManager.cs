using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    private int _playerIndex = -1; // 플레이어 인덱스를 저장할 변수

    // GameManager의 유일한 인스턴스에 접근하는 프로퍼티
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
        // 인스턴스가 이미 있을 경우 현재 GameManager 스크립트를 파괴
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

    // 플레이어 인덱스 설정 메서드
    public void SetPlayerIndex(int index)
    {
        _playerIndex = index;
    }

    // 플레이어 인덱스를 가져오는 메서드
    public int GetPlayerIndex()
    {
        return _playerIndex;
    }

}
