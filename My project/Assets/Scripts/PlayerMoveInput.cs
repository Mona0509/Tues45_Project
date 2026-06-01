using UnityEngine;

public class PlayerMoveInput : MonoBehaviour
{
    [SerializeField] private RhythumTiming timing;

    static public bool isTallJump = false;
    static public bool isNomalJump = false;
    static public bool isGound = false;

    float isGoundPos = 1.0f;

    void Update()
    {
        // ジャンプフラグ,入力
        // 高いジャンプ
        if (Input.GetKeyDown(KeyCode.A) && isGound)
        {
            isTallJump = true;
        };
        // 普通のジャンプ
        if (Input.GetKeyDown(KeyCode.S) && isGound)
        {
            isNomalJump = true;
        };

        Vector3 playerPos = transform.position;
        Ray ray = new Ray(playerPos,Vector3.down);
        isGound = Physics.Raycast(ray, isGoundPos);

        if (Input.GetKeyDown(KeyCode.D))
        {
            timing.IsClickManager();
        }
    }
}
