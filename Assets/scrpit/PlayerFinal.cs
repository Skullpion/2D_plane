using UnityEngine;

namespace KIDSU
{
    /// <summary>
    /// 玩家結束管理：死亡或過關
    /// </summary>
    public class PlayerFinal : MonoBehaviour
    {
        // 被刪除時會執行一次
        private void OnDestroy()
        {
            // 死亡
            FinalManager.instance.GameOver("Game Over...");
        }

        // 碰到勾選 Is Trigger 物件時會執行一次
        private void OnTriggerEnter2D(Collider2D collision)
        {
            // 過關
            FinalManager.instance.GameOver("You Win!!!");
        }
    }
}
