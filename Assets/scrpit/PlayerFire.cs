using UnityEngine;

namespace KIDSU
{
    /// <summary>
    /// 玩家射擊系統
    /// </summary>
    public class PlayerFire : FireSystem
    {
        //偵測玩家行為:鍵盤，滑鼠，觸控與搖桿
        private void Update()
        {
            // 如果 玩家 按下空白建 就 生成子彈
            if (Input.GetKeyDown(KeyCode.Space))
            {
                
                SpawnBullet();

            }

        }
    }
}
