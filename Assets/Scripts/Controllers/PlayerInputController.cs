using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

// 2. Input이 발생했을 때 동작을 처리하는 함수를 만든다. Controller를 상속받는다.
public class PlayerInputController : PlayerController
{
    // 메인 카메라
    private Camera _camera;
    private void Awake()
    {
        _camera = Camera.main; // 태그가 메인 카메라인 것을 찾음.
    }

    // 3. Send Message방식. 실행됐을 때 돌려받는 값
    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }

    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim);
        // 캐릭터와 마우스 포인터의 위치의 거리 차이가 벡터값으로 나온다. 그 벡터값을 normalized하면, 마우스가 위치한 곳으로 바라보는 기능을 제작할 수 있는 것!
        newAim = (worldPos - (Vector2)transform.position).normalized;

        // magnitude = 크기, (normalized했으니 1)
        if(newAim.magnitude >= .9f)
        {
            CallLookEvent(newAim);
        }
    }
}
