using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    float distance = 20000.0f;  // 레이의 길이
    RaycastHit rayHit;          // 레이가 맞았다는 걸 알려주는 변수
    Ray ray;                    // 사용될 레이 변수

    // Start is called before the first frame update
    void Start()
    {
        ray = new Ray();        // 레이 생성
    }

    // Update is called once per frame
    void Update()
    {
        ray.origin = this.transform.position;   // 레이 위치를 사용될 오브젝트 위치에 적용
        ray.direction = this.transform.forward; // 레이 방향을 사용될 오브젝트 방향으로 초기화

        // 레이와 오브젝트가 충돌했을 때
        if(Physics.Raycast(ray.origin, ray.direction, out rayHit, distance))
        {
            Debug.Log(rayHit.collider.gameObject.name);
        }
    }

    // 레이 잘 발사되는지 확인
    private void OnDrawGizmos()
    {
        Debug.DrawRay(ray.origin, ray.direction * distance, Color.red);
    }
}
