using UnityEngine;
using UnityEngine.SceneManagement;

public class JoinBtn : MonoBehaviour
{
    public EnterNameTxt _enterNameTxt;
    public GameObject player1;
    public GameObject player2;

    public void OnJoinButtonClick()
    {
        if (_enterNameTxt != null)
        {
            string _playerName = _enterNameTxt.GetPlayerName();

            if (!string.IsNullOrEmpty(_playerName))
            {
                int playerIndex = -1; // 초기화된 플레이어 인덱스 변수

                // Player1과 Player2 게임 오브젝트의 활성화 상태를 확인하여 인덱스 설정
                if (player1 != null && player1.activeSelf)
                {
                    playerIndex = 0; // Player1이 활성화된 경우 인덱스 0 저장
                }
                else if (player2 != null && player2.activeSelf)
                {
                    playerIndex = 1; // Player2가 활성화된 경우 인덱스 1 저장
                }

                // PlayerManager에 플레이어 이름 및 인덱스 설정
                PlayerManager.Instance.SetPlayerName(_playerName);

                // GameManager에 플레이어 인덱스 설정
                GameManager.Instance.SetPlayerIndex(playerIndex);

                Debug.Log($"{_playerName}");
                Debug.Log($"플레이어 인덱스: {playerIndex}");

                SceneManager.LoadScene("MainScene");
            }
            else
            {
                Debug.Log("2~10글자로 입력해주세요.");
            }
        }
        else
        {
            Debug.LogError("이름이 비었습니다.");
        }
    }
}
