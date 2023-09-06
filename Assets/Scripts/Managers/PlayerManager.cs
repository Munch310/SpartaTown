using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private string _playerName;

    private static PlayerManager instance;

    public static PlayerManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<PlayerManager>();
                if (instance == null)
                {
                    GameObject manager = new GameObject("PlayerManager");
                    instance = manager.AddComponent<PlayerManager>();
                }
            }
            return instance;
        }
    }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
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
}