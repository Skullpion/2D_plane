using UnityEngine;

namespace KIDSU
{
    /// <summary>
    /// ���a�����޲z�G���`�ιL��
    /// </summary>
    public class PlayerFinal : MonoBehaviour
    {
        // �Q�R���ɷ|����@��
        private void OnDestroy()
        {
            // ���`
            FinalManager.instance.GameOver("Game Over...");
        }

        // �I��Ŀ� Is Trigger ����ɷ|����@��
        private void OnTriggerEnter2D(Collider2D collision)
        {
            // �L��
            FinalManager.instance.GameOver("You Win!!!");
        }
    }
}
