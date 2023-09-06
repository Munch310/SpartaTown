using UnityEngine;
using UnityEngine.UI;

public class EnterNameTxt : MonoBehaviour
{
    public InputField _playerNameInput;
    private string _playerName = null;

    private void Awake()
    {
        if (_playerNameInput != null )
        {
            _playerName = _playerNameInput.GetComponent<InputField>().text;

            // InputField의 "Submit" 이벤트에 이벤트 핸들러를 추가
            _playerNameInput.onEndEdit.AddListener(OnSubmit);
        }
        else
        {
            Debug.LogError("플레이어 이름을 올바르게 입력하세요.");
        }
    }

    // "Submit" 이벤트 핸들러
    private void OnSubmit(string value)
    {
        // 플레이어가 엔터 키를 누르거나 입력을 완료했을 때 호출됨
        // value 매개변수에는 InputField의 현재 텍스트가 전달됨
        _playerName = value;

        // 필요한 추가 동작을 수행 (예: 이름 입력 후 다음 단계로 이동)
        Debug.Log($"플레이어 이름 입력 완료: {_playerName}");
    }

    public string GetPlayerName()
    {
        if (_playerName.Length >= 2 && _playerName.Length <= 10)
        {
            return _playerName;
        }
        else
        {
            return "";
        }
    }
}
